using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HttpContextSubs
{
    public class SessionSub : ISession {
        public bool IsAvailable { get; }
        public string Id { get; }
        public IEnumerable<string> Keys => _dic.Keys;

        private readonly Dictionary<string, byte[]> _dic = new Dictionary<string, byte[]>();

        public void Clear() {
            _dic.Clear();
        }

        public Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken)) {
            return Task.CompletedTask;
        }

        public Task LoadAsync(CancellationToken cancellationToken = default(CancellationToken)) {
            return Task.CompletedTask;
        }

        public void Remove(string key) {
            _dic.Remove(key);
        }

        public void Set(string key, byte[] value) {
            _dic[key] = value;
        }

        public bool TryGetValue(string key, out byte[] value) {
            return _dic.TryGetValue(key, out value);
        }
    }
}