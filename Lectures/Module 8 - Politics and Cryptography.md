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
