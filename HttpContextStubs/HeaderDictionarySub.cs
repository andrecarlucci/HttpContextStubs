using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HttpContextSubs
{
    public class HeaderDictionarySub : IHeaderDictionary {

        private readonly Dictionary<string, StringValues> _dic = new Dictionary<string, StringValues>();

        public StringValues this[string key] {
            get {
                return _dic[key];
            }
            set {
                _dic[key] = value;
            }
        }

        public long? ContentLength { get; set; }
        public ICollection<string> Keys => _dic.Keys;
        public ICollection<StringValues> Values => _dic.Values;
        public int Count => _dic.Count;
        public bool IsReadOnly { get; }

        public void Add(string key, StringValues value) {
            _dic.Add(key, value);
        }

        public void Add(KeyValuePair<string, StringValues> item) {
            _dic.Add(item.Key, item.Value);
        }

        public void Clear() {
            _dic.Clear();
        }

        public bool Contains(KeyValuePair<string, StringValues> item) {
            return _dic.ContainsKey(item.Key) && _dic[item.Key] == item.Value;
        }

        public bool ContainsKey(string key) {
            return _dic.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, StringValues>[] array, int arrayIndex) {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, StringValues>> GetEnumerator() {
            return _dic.GetEnumerator();
        }

        public bool Remove(string key) {
            return _dic.Remove(key);
        }

        public bool Remove(KeyValuePair<string, StringValues> item) {
            foreach(var kv in _dic) {
                if(kv.Key == item.Key && kv.Value == item.Value) {
                    return _dic.Remove(kv.Key);
                }
            }
            return false;
        }

        public bool TryGetValue(string key, out StringValues value) {
            return _dic.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _dic.GetEnumerator();
        }
    }
}
