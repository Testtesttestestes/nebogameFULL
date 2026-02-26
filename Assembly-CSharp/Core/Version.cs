using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core
{
	// Token: 0x02000E6B RID: 3691
	[Token(Token = "0x2000E6B")]
	[Serializable]
	public struct Version
	{
		// Token: 0x06005A01 RID: 23041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A01")]
		[Address(RVA = "0xA713", Offset = "0xA713", VA = "0xA713")]
		private Version(Version.Builder builder)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Version___ctor(float *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60559 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a60559 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  if ((uint)ABS(*param1) < 0x7f800001) {
		    Sirenix_Serialization_BaseFormatter_Nullable_int____RegisterReferenceID(param1_00,*param1,0);
		    func_ii_3135(param1_00,0x2e,0);
		  }
		  if ((uint)ABS(param1[1]) < 0x7f800001) {
		    Sirenix_Serialization_BaseFormatter_Nullable_int____RegisterReferenceID(param1_00,param1[1],0);
		    func_ii_3135(param1_00,0x2e,0);
		  }
		  if ((uint)ABS(param1[2]) < 0x7f800001) {
		    Sirenix_Serialization_BaseFormatter_Nullable_int____RegisterReferenceID(param1_00,param1[2],0);
		  }
		  iVar1 = func_ii_4769(param1[3],0);
		  if (iVar1 == 0) {
		    func_ii_2010(param1_00,param1[3],0);
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  return uVar2;
		}
		*/

		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A02")]
		[Address(RVA = "0xA714", Offset = "0xA714", VA = "0xA714", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		public const char NUMERIC_SEPARATOR = '.';

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x0")]
		public float Major;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x4")]
		public float Minor;

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0x8")]
		public float Patch;

		// Token: 0x04003141 RID: 12609
		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0xC")]
		public string Meta;

		// Token: 0x02000E6C RID: 3692
		[Token(Token = "0x2000E6C")]
		public class Builder
		{
			// Token: 0x17001252 RID: 4690
			// (get) Token: 0x06005A03 RID: 23043 RVA: 0x0000FF48 File Offset: 0x0000E148
			// (set) Token: 0x06005A04 RID: 23044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001252")]
			public float Major
			{
				[Token(Token = "0x6005A03")]
				[Address(RVA = "0xA715", Offset = "0xA715", VA = "0xA715")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005A04")]
				[Address(RVA = "0xA716", Offset = "0xA716", VA = "0xA716")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001253 RID: 4691
			// (get) Token: 0x06005A05 RID: 23045 RVA: 0x0000FF60 File Offset: 0x0000E160
			// (set) Token: 0x06005A06 RID: 23046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001253")]
			public float Minor
			{
				[Token(Token = "0x6005A05")]
				[Address(RVA = "0xA717", Offset = "0xA717", VA = "0xA717")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005A06")]
				[Address(RVA = "0xA718", Offset = "0xA718", VA = "0xA718")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x06005A07 RID: 23047 RVA: 0x0000FF78 File Offset: 0x0000E178
			// (set) Token: 0x06005A08 RID: 23048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001254")]
			public float Patch
			{
				[Token(Token = "0x6005A07")]
				[Address(RVA = "0xA719", Offset = "0xA719", VA = "0xA719")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005A08")]
				[Address(RVA = "0xA71A", Offset = "0xA71A", VA = "0xA71A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001255 RID: 4693
			// (get) Token: 0x06005A09 RID: 23049 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06005A0A RID: 23050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001255")]
			public string Meta
			{
				[Token(Token = "0x6005A09")]
				[Address(RVA = "0xA71B", Offset = "0xA71B", VA = "0xA71B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005A0A")]
				[Address(RVA = "0xA71C", Offset = "0xA71C", VA = "0xA71C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06005A0B RID: 23051 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A0B")]
			[Address(RVA = "0xA71D", Offset = "0xA71D", VA = "0xA71D")]
			public Version.Builder SetMajor(float value)
			{
				return null;
			}

			// Token: 0x06005A0C RID: 23052 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A0C")]
			[Address(RVA = "0xA71E", Offset = "0xA71E", VA = "0xA71E")]
			public Version.Builder SetMinor(float value)
			{
				return null;
			}

			// Token: 0x06005A0D RID: 23053 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A0D")]
			[Address(RVA = "0xA71F", Offset = "0xA71F", VA = "0xA71F")]
			public Version.Builder SetPatch(float value)
			{
				return null;
			}

			// Token: 0x06005A0E RID: 23054 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A0E")]
			[Address(RVA = "0xA720", Offset = "0xA720", VA = "0xA720")]
			public Version.Builder SetMeta(string value)
			{
				return null;
			}

			// Token: 0x06005A0F RID: 23055 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A0F")]
			[Address(RVA = "0xA721", Offset = "0xA721", VA = "0xA721")]
			public Version.Builder Parse(string value)
			{
				return null;
			}

			// Token: 0x06005A10 RID: 23056 RVA: 0x0000FF90 File Offset: 0x0000E190
			[Token(Token = "0x6005A10")]
			[Address(RVA = "0xA722", Offset = "0xA722", VA = "0xA722")]
			public Version Build()
			{
				return default(Version);
			}

			// Token: 0x06005A11 RID: 23057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A11")]
			[Address(RVA = "0xA723", Offset = "0xA723", VA = "0xA723")]
			public Builder()
			{
			}

			// Token: 0x04003146 RID: 12614
			[Token(Token = "0x4003146")]
			[FieldOffset(Offset = "0x0")]
			public static string NUMERIC_VERSION_PATTERN;
		}
	}
}
