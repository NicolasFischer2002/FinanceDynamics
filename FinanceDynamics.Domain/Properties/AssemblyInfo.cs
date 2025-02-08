using System.Runtime.CompilerServices;

// --------------------------------------------------------------------------------------
// AssemblyInfo.cs
// --------------------------------------------------------------------------------------
// This file is used to define assembly-level attributes for the FinanceDynamics.Domain project.
// 
// Purpose:
// - To configure metadata about the assembly (e.g., title, version, or visibility settings).
// - To enable or restrict access to internal members from other assemblies.
// 
// Key Attribute:
// - [InternalsVisibleTo("FinanceDynamics.Application")]:
//   Grants the FinanceDynamics.Application assembly access to internal members of this assembly.
//   This is used to enforce proper layering in the Clean Architecture, ensuring that only the
//   Application layer can create or manipulate domain objects directly, adhering to design principles.
//
// Notes:
// - Ensure that the specified assembly name ("FinanceDynamics.Application") matches the project name
//   exactly, including casing.
// - Do not expose internal members to unintended assemblies to maintain proper encapsulation.
//
// For further details, refer to:
// https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.internalsvisibletoattribute
// --------------------------------------------------------------------------------------

[assembly: InternalsVisibleTo("FinanceDynamics.Application")]