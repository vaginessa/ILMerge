# ILMerge

ILMerge takes a set of input assemblies and merges them into one target assembly. The first assembly in the list of input assemblies is the primary assembly. When the primary assembly is an executable, then the target assembly is created as an executable with the same entry point as the primary assembly. Also, if the primary assembly has a strong name, and a .snk file is provided, then the target assembly is re-signed with the specified key so that it also has a strong name.

ILMerge is packaged as a console application. But all of its functionality is also available programmatically.

There are several options that control the behavior of ILMerge. See the documentation that comes with the tool for details.

The current version is 2.14.1208 (created on 8 December 2014). NOTE: There is no longer a version of ILMerge that runs in the v1.1 runtime.

ILMerge runs in the v4.0 .NET Runtime, but it is also able to merge assemblies from other framework versions using the /targetplatformoption. Please see the documentation. (However, it can merge PDB files only for v2 (and later) assemblies.)

Currently, ILMerge works only on Windows-based platforms. It does not yet support Rotor or Mono.
