Positive Integers, finite numbers. In computers everything is a number, even more so it is a binary number. All numbers, even negative are represented as positive numbers in binary. Cryptography breaks down numbers into blocks of 128/256 ect...
Even though algorithms aren't always based on number theory, like aes and sha, they can often be broken using number theory.
[[Algorithms#RSA|RSA]], [[Algorithms#RSA]], DH... are more based in number theory.
Number theory is the purest form of math.
At one point do numbers get so large that breaking the maximum does overflowing them become impossible? 2^128 will take 10 trillion trillion years, making it impossible to break even when computer speed increase exponentially.
Range of a 128 bit number is large. Two random numbers can be said to not be equal, its just to impossible of a chance. Therefore 128 bit hash functions do not collide. This makes encryption impossible because you have to guess the other two numbers for the final product. Therefore large numbers are never broken with brute force.
# Prime Numbers
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
# Random Numbers
What is a random number? Given the range 0-9 are they all random numbers? Humans often avoid the edge cases like 0 or 9 but in reality all the numbers are random.
Sequences are obvious not random if they have patterns such as 000000 or 012012012
Its hard to define exactly what makes a sequence random. Advanced statistical tests can help determine patterns.
How do you generate a random sequence? or how to you generate a random number? Computers are deterministic machines and therefore every random sequence will be generated the same. Often they use externally determined seeds to generate random numbers.
Programmatically its not the total random numbers but that statically they are random, this is not true for cryptography, they need to be truly unpredictable.
Can be used to create keys.
Nonces - seeding and challenge response
any given number is a random number
Not all numbers in a sequence is always random
Best method of generating randomness is from nature.
Linear congruence generators. Statistically pretty random but not random for cryptography.
Statistical randomness vs crypto secure randomness.
If two people generate two random numbers they are not the same. (for large numbers). The probability of it actually happening is so rare it is basically 0.

Frequency, serial, poker, gap tests can be used to test if a number is actually random.
Pseudo random generators, random numbers generated from a sequence. PRBG, pseudo random bit generator. The randomness is determined on the randomness in the seed, eventually the sequence of numbers generated from the same seed will repeat (trillions of years).

## Frequency Tests
how long does the sequence take to repeat. Can be spoofed by generating all numbers in order from 1 to n.
## Serial Tests
Frequency tests for pairs of number. will prevent spoofing of the frequency tests
## Poker Tests
5 number frequency tests
## Gap Tests
choose 1 number and check the distribution of that number across the sequence. 
## CSPRNG
very unpredictable. Indistinguishable from real random numbers.
NBT - next bit tests. given a large number of random generated bits, the next bit cannot be predicted, or that the ability to predict is no different then guessing. for bits the results should be 50% correct.
State compromised test - can you use the current state if captured to generate the previous state of the machine.
* Math - can use number theory to generate a random number - Blum Blum Shub - uses two primes greater than 1000 bits in a formula, outputs one bit at a time. say for 2000 bits to get the 2001's bit you need to calculate the whole thing 2000 times. Can be state compromised but is very difficult to calculate to the point where it is considered secure.
* Crypto algorithms - encryption, and hash functions. counter mode, counters to generate the input and the seed is random. Can be state compromised as if you know the current input you can generate the previous inputs. By changing up the input you can pass the test.
### NIST 800-90A
tells you how to create random number generator.
Two ways of generating random numbers,
DRGB - Deterministic Random Bit Generator
#### HASH - DRGB
uses hash function in counter mode
#### HMAC - DRGB
hash message authentication codes.
