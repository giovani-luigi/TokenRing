using System;
using System.Diagnostics;
using System.Threading;

namespace TokenRingDemo.Protocol
{
    internal class TokenVault {

        public event EventHandler TokenLocked;
        public event EventHandler TokenUnlocked;
        public event EventHandler TokenExpired;

        private volatile bool _token = false;
        private volatile bool _locked = false;
        private readonly object _monitor = new object();
        private readonly Timer _timer;
        private readonly Stopwatch _stopwatch;

        public TimeSpan Timeout { get; private set; }

        public bool HasToken => _token;

        public TimeSpan RemainingTime {
            get {
                lock (_monitor) {
                    return (Timeout - _stopwatch.Elapsed);
                }
            }
        }

        public TokenVault() {
            _timer = new Timer(OnTimeout);
            _stopwatch = new Stopwatch();
        }

        public bool SetToken(TimeSpan timeout) {
            Timeout = timeout;
            lock (_monitor) {
                if (_token) return false;
                _token = true;
                _timer.Change((int)timeout.TotalMilliseconds, -1);
                _stopwatch.Restart();
                return true;
            }
        }

        public bool TryLockToken() {
            lock (_monitor) {
                if (!_token) return false;
                _timer.Change(-1, -1);
                _stopwatch.Stop();
                _locked = true;
            }
            TokenLocked?.Invoke(this, EventArgs.Empty);
            return true;
        }

        public bool TryUnlockToken() {
            lock (_monitor) {
                if (!_token) return false;
                if (!_locked) return false;
                _locked = false;
                int remainingTime = (int)RemainingTime.TotalMilliseconds;
                _timer.Change(remainingTime > 0 ? remainingTime : 0, -1);
                _stopwatch.Start();
            }
            TokenUnlocked?.Invoke(this, EventArgs.Empty);
            return true;
        }

        private bool TryClearToken() {
            lock (_monitor) {
                if (_locked) return false;
                _timer.Change(-1, -1);
                _stopwatch.Reset();
                _token = false;
                return true;
            }
        }


        private void OnTimeout(object state) {
            if (TryClearToken()) {
                TokenExpired?.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
