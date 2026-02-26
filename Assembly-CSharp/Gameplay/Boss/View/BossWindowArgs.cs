using System;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B4C RID: 2892
	[Token(Token = "0x2000B4C")]
	public class BossWindowArgs : BaseWindowArgs
	{
		// Token: 0x06004604 RID: 17924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004604")]
		[Address(RVA = "0x949E", Offset = "0x949E", VA = "0x949E")]
		public BossWindowArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_BossWindowArgs___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_BossWindowState___ctor__);
		    DAT_ram_00a579a5 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_BossWindowState___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0x18")]
		public BossInstance BossInstance;

		// Token: 0x0400263F RID: 9791
		[Token(Token = "0x400263F")]
		[FieldOffset(Offset = "0x1C")]
		public BossWindowState Tab;
	}
}
