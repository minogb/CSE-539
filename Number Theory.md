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