Finite Field Tools
==================
This solution implements a naive Finite Field Arithmetic using C#. The solution has been developed as a term project for the graduate course "IAM705 Stream Cipher Cryptanalysis" during the 2012 Spring Semester at [IAM, METU](http://www.iam.metu.edu.tr)

The solution is written in C# 4.0 using Visual Studio 2010. It is now upgraded to Visual Studio 2012 solution.

FiniteFieldArithmetics
----------------------
* This is the main library that implements all the operations.
* It implements Finite Field, Extension Finite Field and Polynomial based operations.
* Also, a naive LFSR based stream generator is included. Besides, well known Berlekamp-Massey Algorithm for Finite Fields is also included.
* Hellman's TMTO Attack (using Hellman Tables) is also implemented in the library.

All other projects make use of the FiniteFieldArithmetics library. So, they are examples of using the library.

Here are the brief explanations of the example projects:

### FiniteFieldExample ###
This Windows.Forms project shows some simple operations related to Finite Fields using the FiniteFieldArithmetics library.

### BerlekampMasseyExample ###
This Windows.Forms project is a simple way to use Berlekamp-Massey Algorithm. Just enter the finite field size and a proper sequence and get the results from the algorithm.

### BerlekampMasseyWeb ###
This is the web application form of the BerlekampMasseyExample project. It has the same properties.<br />An online demo of the project can be accessed from [http://kriptografi.net/tools/BerlekampMasseyWeb/Default.aspx](http://kriptografi.net/tools/BerlekampMasseyWeb/Default.aspx)

### LFSRSequenceGeneratorExample ###
This Windows.Forms application is a useful LFSR stream generator. It takes finite field size, initial state and feedback polynomial as inputs and enables clocking the LFSR at any rate. It also includes the period calculation for the given LFSR.

### HellmanTablesExample ###
This Windows.Forms application is a nice example of Hellman's TMTO Attack. It attacks on a 32-bit toy hash function derived from SHA1.

There are 3 basic parts in the program.

1.  Hash calculation: For the 32-bit toy hash function, this part allows to compute the 32-bit hash value for any 32-bit input.

2.  Precomputation: For specific parameters of Hellman's Table, this part computes and saves the tables.

3.  Attack: Using the precomputed tables, this part tries to find a pre-image for a given hash value.

### Homework4Example ###
This project includes some algorithms for a homework. It consists 3 main parts:

1. Order of Polynomial: This part finds the order of a polynomial over a finite field.

2. Non-linear Combiner: This part implements a non-linear combiner using LFSRs and Boolean Functions. It computes the period and linear complexity of the output of the non-linear combiner.

3. Binary stream operations: For a given binary stream, this part computes the number of runs in the stream and finds the auto correlation values.
