Biometrics are not always great, you cannot change your biometrics and the are shared across all sights. However, these must be stolen plaintext. Good for in person identification, over the internet there are to many issues.

Should the plaintext or hash be sent to the host? always send the plaintext otherwise the hash basically becomes the hash. Sending the hash does not add to security.
Normal password storage storage is prone to dictionary attacks. Without salting the dictionary is precomputed and cost very little to attack. Each salt is stored the password and is unique to that password.
# Unix Password Storage
in 1970 the hashed and salted using a now outdated scheme but still is important to understand.
Unix said max 8 character passwords. represented characters as 7 bit bytes so they were 56 bits. it then added 2 character random salt total 10 characters. Hashing didn't really exist then so the plaintext password was sent to a DES encrypted using the password and salt as the key, then they des again for a total of 25 times all using the same key. This didn't strengthen the key but forced extra computer power to slow attackers down.
The salt is used to perturb some of the sboxes of DES.

Note run thousands of rund of hashing to make it more secure, this would elminate a lot of password leaking with 256 bit salting.