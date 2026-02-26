using System;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Gameplay.ArtifactComparer.Model
{
	// Token: 0x02000CE7 RID: 3303
	[Token(Token = "0x2000CE7")]
	public class ComparedSkillData : SkillData
	{
		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x0000EB80 File Offset: 0x0000CD80
		// (set) Token: 0x06005063 RID: 20579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001046")]
		public ComparedSkillData.ComparisonResult CompareResult
		{
			[Token(Token = "0x6005062")]
			[Address(RVA = "0x9E73", Offset = "0x9E73", VA = "0x9E73")]
			[CompilerGenerated]
			get
			{
				return ComparedSkillData.ComparisonResult.NotCompared;
			}
			[Token(Token = "0x6005063")]
			[Address(RVA = "0x9E74", Offset = "0x9E74", VA = "0x9E74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x0000EB98 File Offset: 0x0000CD98
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001047")]
		public bool SkillEnabled
		{
			[Token(Token = "0x6005064")]
			[Address(RVA = "0x9E75", Offset = "0x9E75", VA = "0x9E75")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005065")]
			[Address(RVA = "0x9E76", Offset = "0x9E76", VA = "0x9E76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005066")]
		[Address(RVA = "0x9E77", Offset = "0x9E77", VA = "0x9E77")]
		public ComparedSkillData(int id)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_Model_ComparedSkillData___ctor(undefined4 param1,undefined4 param2)
		
		{
		  System_Collections_Generic_List_object____ctor(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_Model_ComparedSkillData___ctor(undefined4 param1,undefined4 param2)
		
		{
		  System_Collections_Generic_List_object____ctor(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005067 RID: 20583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005067")]
		[Address(RVA = "0x9E78", Offset = "0x9E78", VA = "0x9E78")]
		public ComparedSkillData(SkillData skillData)
		{
		}

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		[FieldOffset(Offset = "0x28")]
		public string DebugString;

		// Token: 0x02000CE8 RID: 3304
		[Token(Token = "0x2000CE8")]
		public enum ComparisonResult
		{
			// Token: 0x04002BFA RID: 11258
			[Token(Token = "0x4002BFA")]
			NotCompared,
			// Token: 0x04002BFB RID: 11259
			[Token(Token = "0x4002BFB")]
			Equals,
			// Token: 0x04002BFC RID: 11260
			[Token(Token = "0x4002BFC")]
			Less,
			// Token: 0x04002BFD RID: 11261
			[Token(Token = "0x4002BFD")]
			Greater
		}
	}
}
