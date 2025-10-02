# Encryption With Backdoors
Surveillance -> Meta data
Can a service provider decrypt communication? yes it can do a man in the middle attack
Push from law enforcement to have backdoors
Any cryptographic system wit a backdoor is fundamentally insecure
Why can't we just layer a secure system on top of the backdoored system? It could be outlawed in some back way.

Clipper Chip
used a algorithm called skipjack. Skipjack was secrete and not a public algorithm
Phil Zimmerman created PGP (email) was made to illegal to export from us so zimmerman made a book to 'export' it.

## Backdoors
One way to do it is to always append the key in the message that was used to encrypt the message encrypted with the master key.

## Chaffing and Winnowing
Encryption is illegal but just make all your messages unreadable. Send out a bunch of bits that some are good and others are bad. The MAC can be used to verify the individual bits.

----------
# Plausible Deniability
Client deny the action and third party cannot prove it was done.
Unencrypted communication it easy to have deniability
SSL also does. the server can reconstruct all information provided by the client
Email with PGP or a signature scheme does not have Plausible deniability
# Perfect Forward Security
If the keys on a computer is compromised, communication is not exposed

To get both:
- Use ephemeral keys (DH)
- Use MAC
- How do you authenticate
# Detect MITM with DH
OTR - off the record protocol
Signal - Open Whisper System, PIDGIN, ?Whatsapp?
AKE - Authenticated Key Exchange
Alice -> encrypte with r (g^a) to bob
and bob sends g^b
where r is a random number
Alice sends to bob R clear text, Encrypted shared secrete (public A, signature A)
Bob sends to allice a similar message

After all this complete a MITM detection.
- Socialist Millionaire Problem
	- Millionaire Problem (compare each others wealth without sharing how much money they have)
Socialist Millionaire problem is to compare each other and only find out if they are equally wealthy
mix up a table of created values generated from a preshared secrete to share with each other. This shared secrete is only used to verify each other not for messaging. that way it maintains plausible deniability
# Secure Elections
Rules:
- Only authorized voters can vote
- No multiple vote
- Voter ID
- Voter ID and vote should not be correlated
- No one can change vote
- Every vote is counted
Hard to accomplish more security electronically as the electronic introduces more issues than it solves