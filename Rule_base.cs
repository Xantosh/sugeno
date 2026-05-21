using System;

namespace sugeno {

    public class Rule_base {
        
        public void Compute((float, float, float) strength, (float, float, float) money) {
            // Process strength and money tuples efficiently
            var (s1, s2, s3) = strength;
            var (m1, m2, m3) = money;
            
            // Example computation - customize based on your needs
            float result = (s1 + s2 + s3 + m1 + m2 + m3) / 6f;
            
            return;
        }
    }
}
