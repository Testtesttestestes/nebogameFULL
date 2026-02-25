using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x060000F5 RID: 245 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x55BA", Offset = "0x55BA", VA = "0x55BA")]
	[MethodImpl(256)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x55BB", Offset = "0x55BB", VA = "0x55BB")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	private struct MonoScriptData
	{
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x4")]
		public byte[] TypesData;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x8")]
		public int TotalTypes;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xC")]
		public int TotalFiles;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x10")]
		public bool IsEditorOnly;
	}
}
