Fast exponentiation -> multiplying large numbers -> long multiply
x^ 25 -> x^2 * x^ 4 * x^ 16 -> x^4 * x^16 * x -> x^20 * x^ 4 * x -> x^24 * x

x^y 
for the ptr from max bit (msb) to first bit (lsb) of the exponent
	if bit(ptr) = 0 ? result = result ^2
	else result = result ^2 * x

Probabilistic Algorithm
- Las Vegas Style - terminate, correct, runtime varies (ie may not return a result)
- Monte Carlo - May not terminate, may have wrong results, runtime deterministic 
see calculating value of pi. 
one way is to take a point on a square of -1,-1 to 1,1 and calculate if it is in the circle of pi, do it X number of times. using these points you calculate an approximate value of pi that gets more accurate the more you do it.

Fermats primality test
if p is prime and a < p then a^(p-1) = 1 mod p where a is a random number and p is a candidate prime
if result is not 1 then p is not prime and if it is 1 then p may be prime

Miller Rabin primality test
the equation x^2 = 1 mod p
	has two roots +1 & -1 if p is prime
x^2 = 1 mod p
x^2 = alpha p + 1
x^2 -1 = alpha p
(x+1)(x-1) = alpha p.
one of the two +1 or -1 must have a factor p

Therefore if you take the same steps as fast prime you get a^p-1
for the ptr from max bit (msb) to first bit (lsb) of the exponent
	if bit(ptr) = 0 ? then it must be +/-1
	else is not prime
repeat test for a bunch of a values

--------
Generating Private/public keys
Extended Euclidean Algorithm (GCD)
GCD of two numbers p and q is = x * p + y * q
where x and y are the output values
if you subsite q(n) for p and e for q in above then
GCD(q(n),e) = x * q(n) + y * e
1 = x * q(n) + y * e
1 = y * e mod q(n)
y is d


Extended Euclidean Algorithm
ax + by = gcd(a, b)