using System;

namespace sugeno {
    class mother {
        public static void Main(string[] args) {
            var tuple = (0.1f, 0.5f, 0.7f);
            Rule_base rb = new Rule_base();
            rb.Compute(tuple, tuple);
        }
    }
}
