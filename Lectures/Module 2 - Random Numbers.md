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

# Frequency Tests
how long does the sequence take to repeat. Can be spoofed by generating all numbers in order from 1 to n.
# Serial Tests
Frequency tests for pairs of number. will prevent spoofing of the frequency tests
# Poker Tests
5 number frequency tests
# Gap Tests
choose 1 number and check the distribution of that number across the sequence. 

------------------
Despite numbers being able to pass the above tests they may no be good crypto numbers.
Crypto secure pseudo random number generators. If the actor knows the previous numbers in the sequence a normal generator could be predicted. crypto secure numbers cannot be. CSPRNG
# CSPRNG
very unpredictable. Indistinguishable from real random numbers.
NBT - next bit tests. given a large number of random generated bits, the next bit cannot be predicted, or that the ability to predict is no different then guessing. for bits the results should be 50% correct.
State compromised test - can you use the current state if captured to generate the previous state of the machine.
* Math - can use number theory to generate a random number - Blum Blum Shub - uses two primes greater than 1000 bits in a formula, outputs one bit at a time. say for 2000 bits to get the 2001's bit you need to calculate the whole thing 2000 times. Can be state compromised but is very difficult to calculate to the point where it is considered secure.
* Crypto algorithms - encryption, and hash functions. counter mode, counters to generate the input and the seed is random. Can be state compromised as if you know the current input you can generate the previous inputs. By changing up the input you can pass the test.
## NIST 800-90A
tells you how to create random number generator.
Two ways of generating random numbers,
DRGB - Deterministic Random Bit Generator
### HASH - DRGB
uses hash function in counter mode
### HMAC - DRGB
hash message authentication codes.
