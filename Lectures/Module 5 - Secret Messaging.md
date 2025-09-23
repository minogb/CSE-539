- Integrity violation - changed cipher mid transmission
- Every message is authentic
MAC - Message Authentication Codes
E((m),h(m)) - this way the receiver can verify the contents of the message using the hash that was appended in the encrypted string. This ensures the message was encrypted with the shared secrete and not perturbed

HMAC - hash MAC - Keyed MAC
HMAC(k,m) = H ((k'xor opad)|| H(k'xor ipad || m))
opad, outer pad, 0x5c5c.... pattern to pad
ipad -> 0x3636.... pattern to pad

HMAC prevents the length extension attack.