SSL/TLS
SSL 2.0 invented 95, and 3.0 updated in 96
TLS 1.2 is current version released in 2008

Handshake
Client -> random number, time, protocol version, cipher suites -> server
Server -> random number, time, certificate, protocol version cipher -> change cipher spec client
Client -> generates 48 byte, premaster secret, encrypt in server public key -> server
Server get premaster secrete.
Both use this premaster secrete to create symmetric keys for application communication

Getting Keys from premaster secrete
- Relies on HMAC
- PRF - pseudo random function PRF(secret, seed)
	- = p_hash(secret, seed). A(0) seed, A(1) HMAC_hash(secrete,A(0)), A(i) HMAC_hash(secrete, a(i-1))
- Pre master secret
TLS uses 4 keys
- Client write secret (c -> s)
- server write secret (s->c)
- client write MAC
- server write MAC
master secrete (48 bytes) = PRF(premaster secrete, client random + server random)
key block = PRF(master secret, server random + client random)
Key block is partitioned to make the 4 TLS keys


!? = concatination