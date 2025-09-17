RSA
cannot decrypt the encrypted text with the public key and cypher text.
Allows us to:
* Authentication
* Key exchange
* Secrete Messaging
* Hybrid Messaging
* Digital Signatures - doc, hash of the doc, and the signature is the encryption of the hash with the private key, can verify by decrypting with the public key
* Digital Certificates - digital signature with a third party key, hash of the id and public key that is signed by a third party.
choose p & q as large primes
N = p * q
compute F(n) = (p-1)(q-1)
Choose e coprime to Q(n) find d such that (e * d) mod N  = 1. 
(e,n) = k1 (pub key) and (d,n) = k2 (private key)
encryption (p)^e mod n

#note remember what coprime means

# Man in the middle attack
* passive attack, eavesdropping - even with encryption you can sniff the fact they are communicating, volume and frequencies
- Selectively modifying packets 
	- such as modifying the key exchanged in a DH key exchange
No good solutions, digital certificates help reduce this but is not great at preventing it

# Digital Signature
