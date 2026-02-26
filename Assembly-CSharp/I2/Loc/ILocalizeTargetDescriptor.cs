using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001389 RID: 5001
	[Token(Token = "0x2001389")]
	public abstract class ILocalizeTargetDescriptor
	{
		// Token: 0x06007702 RID: 30466
		[Token(Token = "0x6007702")]
		public abstract bool CanLocalize(Localize cmp);

		// Token: 0x06007703 RID: 30467
		[Token(Token = "0x6007703")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		// Token: 0x06007704 RID: 30468
		[Token(Token = "0x6007704")]
		public abstract Type GetTargetType();

		// Token: 0x06007705 RID: 30469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007705")]
		[Address(RVA = "0xC06C", Offset = "0xC06C", VA = "0xC06C")]
		protected ILocalizeTargetDescriptor()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_ILocalizeTargetDescriptor___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_TextMeshPro_Label___cctor(0);
		  return;
		}
		*/

		}

		// Token: 0x04003E48 RID: 15944
		[Token(Token = "0x4003E48")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x04003E49 RID: 15945
		[Token(Token = "0x4003E49")]
		[FieldOffset(Offset = "0xC")]
		public int Priority;
	}
}
