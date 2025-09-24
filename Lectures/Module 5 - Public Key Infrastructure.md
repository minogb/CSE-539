Digital Signatures - Encrypt the hash of the data with the private key
- Not forgeable
- Not Alterable
- not Reusable
- Not Repudiable
Do not sign anything you did not create - at least perturb the data received

Digital Certificates
- Takes info
- takes public key
- Computes the hash of the above with a serial number they add
- Sign the hash with the CA private key
- Append the name of the CA

PKI
- Signature
- Certificate Authority
- Trust Management
- Decentralized

Hierarchical certificate allow for other CA to pass along the signatures of other CA by appending the child CA certification and signature of the parent CA. can build 'social network' of CA's

Root CA will often sign of other CA to allow for distribution of CA


Revocation of certificates can't really be done, see OCSP for a standard way to do it - Online certificate status protocol