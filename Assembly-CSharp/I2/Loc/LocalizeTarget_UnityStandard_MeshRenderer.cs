using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001391 RID: 5009
	[Token(Token = "0x2001391")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		// Token: 0x0600773C RID: 30524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773C")]
		[Address(RVA = "0xC09D", Offset = "0xC09D", VA = "0xC09D")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x600773D")]
		[Address(RVA = "0xC09E", Offset = "0xC09E", VA = "0xC09E", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x600773E")]
		[Address(RVA = "0xC09F", Offset = "0xC09F", VA = "0xC09F", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x600773F")]
		[Address(RVA = "0xC0A0", Offset = "0xC0A0", VA = "0xC0A0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00015B70 File Offset: 0x00013D70
		[Token(Token = "0x6007740")]
		[Address(RVA = "0xC0A1", Offset = "0xC0A1", VA = "0xC0A1", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x6007741")]
		[Address(RVA = "0xC0A2", Offset = "0xC0A2", VA = "0xC0A2", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007742")]
		[Address(RVA = "0xC0A3", Offset = "0xC0A3", VA = "0xC0A3", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007743")]
		[Address(RVA = "0xC0A4", Offset = "0xC0A4", VA = "0xC0A4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007744")]
		[Address(RVA = "0xC0A5", Offset = "0xC0A5", VA = "0xC0A5")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
}
