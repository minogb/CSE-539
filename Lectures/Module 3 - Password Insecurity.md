Simple, insecure and has high usability.
Is a word from an alphabet (upper, lower, number and special characters) of a length. without special characters that becomes the amount of 62^N
Most of those strings in that list are also complete nonsense and will never be used.
# Insecurity
* sniffing
* phishing
* leakage
* cross site leakage - passwords are a thing known as shared secret. Multiple people must know the password for it to be usable. Ie the user and server must know the password. Compromise on one system can lead compromise across many systems.
# Attacks
## Password Recovery
What happens when you forget a password?
### Strengthen
...
## Stealing Stored Password
Most passwords are stolen when a server's database is stolen. SQL injection used to be an attack that was common to fool the server into pumping out the passwords.
### Strengthen
* Stored passwords should never be stored plaintext.
* Stored passwords should be hashed (not encrypted)
	* Broken with dictionary attacks with commonly used passwords - mitigate with salting to force regenerating of the dictionary per user.
	* Rainbow table attack
	* Brute Force attack (similar to a dictionary attack)