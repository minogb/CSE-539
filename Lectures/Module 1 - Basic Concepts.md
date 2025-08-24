# Modern Cryptography
Started 1970
cryptography in the open
Number theory started being used
Digital Encrypted Standard, DES
RSA
MD5
DES -> AES
RSA -> RSA/ECC
MD5 -> SHA

Cryptography is purely theoretics. Applied cryptography is taking this theory and applying it, usually to computers.
Open knowledge of pros and cons is important in applied.
Data can be at rest or in motion
stored files or data in routing
Data in motion is easer to tap and change
Crypto = Secrete
Tography = Writing

## Cryptography
Does it work? Yes/No. Yes there are established algorithms that work. No, most algorithms are currently broken or will be broken. Is cryptography security? No. Cryptography is only a part of security. Cryptography is only for transforming inputs into outputs using keys. Keys and management of the raw secure data is the rest. Most breaks for cryptography is being able to go around it by attacking other vectors of the security. Key management is outside of the scope of cryptography.
First known open source algorithm is DES, digital encryption standard. From NSA/NIST(IBM). Despite being the founding of modern crypto it is no longer used as it can be easily brute forced with short keys. 56 Bits
AES, advanced encryption standard replaced DES and is in use today. 128/256/512 bits.
There are others that may work but have yet to be certified or adopted. If you want good crypto reuse proven algorithms, don't try to reinvent the wheel.
Most common hash function is MD5, invented by Rivest. There have been other versions but they all had issues and they kept being fixed culminating in MD5, today MD5 is known to be broken and has been replaced SHA, secure hash algorithm.
# Primary Concepts & Large Numbers
these things can be used for authentication, password management. These things lead into secrete communications. For secrete communications they fundamentally have to be read. This requires things like authenticity and integrity. This often lead into digital signatures and certificates.
Crypto protocols are brittle, subtle and error prone. This can make things look better than they are and slight changes to it can break everything
Anyone can create an algorithm that the creator cannot break. This doesn't mean it cannot be broken. Secure algorithms usually mean no one has figured out how to break them, yet. Knowledge of the algorithms used in products should be well known so people can verify security of the service.
Coin toss protocol revolves around making a 50/50 guess on a secrete and if you are right the hidden contents are reveled. Correct guess and be faked in both correct or false. To make this work, feed X into a function to get Y so you cannot get X from Y. Instead of transmitting the results you transmits the results of the hash Y. The guess C is transmitted back and the fed back through the hash to verify the results by the guesser. (requires collision free hashing)
## Random numbers

## Hash Functions

## Encryption
Symmetric and asymmetric

## Number Theory
Positive Integers, finite numbers. In computers everything is a number, even more so it is a binary number. All numbers, even negative are represented as positive numbers in binary. Cryptography breaks down numbers into blocks of 128/256 ect...
Even though algorithms aren't always based on number theory, like aes and sha, they can often be broken using number theory.
RSA, ECC, DH... are more based in number theory.
Number theory is the purest form of math.
At one point do numbers get so large that breaking the maximum does overflowing them become impossible? 2^128 will take 10 trillion trillion years, making it impossible to break even when computer speed increase exponentially.
Range of a 128 bit number is large. Two random numbers can be said to not be equal, its just to impossible of a chance. Therefore 128 bit hash functions do not collide. This makes encryption impossible because you have to guess the other two numbers for the final product. Therefore large numbers are never broken with brute force.
### Prime Numbers
Are significant because they have been study for a long time and have always been useless but they have some properties that are useful in crypto. This means they have always formed the bases of number theory.
Take two large prime numbers p and q. Multiply them together to get N. N can be reverse engineered from P and Q but it is almost impossible to find p and q from n. This makes N the public key for encryption in RSA making P and Q private keys.
As numbers get larger they gain more things that can divide it. Euclid tried to prove that if the number of prime numbers are finite. Proof by contradiction, assume they are finite there is a largest prime number. if you take the product of every prime number and then add one, is the final product p prime? if it is you can use it in the series to generate more primes. If it can be divided then the divider cannot b in the set thus the divider is also prime and is larger than the other primes and thus expand the list of prime numbers generating more prime numbers.
Very large prime numbers are almost always unique when they are generated.
# Kerkhof's Principle
* The sequence must be indecipherable
* It should not require secrecy
* It should not be a problem if it is compromised
* It must be possible to remember the key or modify it at will
* It must be applicable to telegraph communications
* It must be portal and should require several persons to operate
* It must not be difficult to use
## Takeaway?
* No secrete algorithms
*  keys cannot be secrete
* Any method/protocol should be open
If you want  to break it? here is the how, good luck.
The secrecy of data should not be reliant on the secrecy of the algorithm.
Many Eyes Theory: the more try to break it and cannot the more likely it is to be secure.
Can security be proven? No, proofs often do not exists as the system relies on specific mechanisms for it to work thus you cannot create a proof.
No one/team human can design a good cryptography system. It must be created in tandem with other teams trying to break it. Part of the issue is that designers do not see flaws
# Build blocks
## Random Numbers
What is a random number? Given the range 0-9 are they all random numbers? Humans often avoid the edge cases like 0 or 9 but in reality all the numbers are random.
Sequences are obvious not random if they have patterns such as 000000 or 012012012
Its hard to define exactly what makes a sequence random. Advanced statistical tests can help determine patterns.
How do you generate a random sequence? or how to you generate a random number? Computers are deterministic machines and therefore every random sequence will be generated the same. Often they use externally determined seeds to generate random numbers.
Programmatically its not the total random numbers but that statically they are random, this is not true for cryptography, they need to be truly unpredictable.
## Hash Functions
Also called one way functions. Fundamentally true one way functions cannot be proved even if they cannot prove a douplicat exists
A function that takes a variable input runs it through a deterministic and creates a fixed data output. This is not reversable because the output is smaller than output. Fundamentally multiple inputs can map to the same output. In crypto this is a problem. An additional problem is that the hash functions can be reversed, the output can never represent the input.
## Encryption Functions
also know as a one way trapdoor function as once executed it cannot go back, but there is a secrete trapdoor to go back.
This function is lossless as the output is not smaller then the input.
Jumble encryption, substitute cyphers, ect... how they were jumbled or subsisted is the secrete trap door. Simplistic functions like these often have correlation between the output and input.
The use of keys allow a two way encryption decryption, another thing that is not present in hash functions.
Symmetric encryption use the same key for encryption and decryption. asymmetric use a public (decryption) and private (encryption) key. For every private key there is exactly one public key.
Symmetric encryption are often ad hawk and can use any technique almost at random and don't require much number theory to design and can use things like lookup tables and often use different algorithms to encrypt and decrypt. Hard to described, easy to execute.
Asymmetric encryption are very number theory derived and are often more simple but are more computational difficult.  Easy to describe, hard toe execute.