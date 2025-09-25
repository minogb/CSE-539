n = p * q
Q(n) = (p-1)(q-1)
e = coprime to Q(n)
d -> e * d mod Q(n) = 1
encrypt m^e mod n
decrypt (m^e)^d mod n

Zn = {0,1,2...n-1} size of Zn |Zn| = n
Z * n = {set of numbers coprime to n} size of Z * n |Z * n| = n - p - q + 1 = pq - p -q + 1 = (p -1)(q-1) = Q(n)

multiplying any two numbers in Z* n is closed under multiplication.
a,b => z* n
(a * b ) mod n is in Z * n

Z * n = {b,b2,b3,... bq(n)}
a in z * n
Sn = { ab, ab2,ab3... abq(n)} mod n = Z * n
assume a pair in Sn are the same then abi = abj mod n
abi = alpha + z
abj = beta n + z

abi - abj = a(bi-bj) = n (alpha - beta)

because a(bi-bj) does not have a factor n, the assumption made earlier is incorrect
therefore Sn =Z* n

Corollary if a in Z * n then there exist a number b in Z * n such that a * b = 1 mod n


Z * n has the following claims
- z * n is closed under multiplication
- Z* n elements multipled by a = Z * n
- Corallary a,b there in Z* n theere exists where a * b = 1 mod n
- If a in Z* n then a ^q(n) = 1 mod n
- if a & q(n) are coprime thenn there is b such that a * b = 1 mod q(n)
----
Prove RSA works
message m < n and choose e that is in Z * q(n) find d such that e * d = 1 mod q(n)
m ^(e * d) mod n = mod ^ (k q(n) + 1) mod n translates to
(m^(q(n) * m(^q(n))... k times) mod n = m

because such large numbers are involved any multiplication is really slow. so you have to use fast exponentiation. From e find d is hard to find. Finding p,q that are both large primes is also hard.