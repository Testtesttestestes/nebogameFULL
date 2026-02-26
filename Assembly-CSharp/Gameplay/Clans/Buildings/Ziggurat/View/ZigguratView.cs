using System;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using UI.Windows.Buildings;

namespace Gameplay.Clans.Buildings.Ziggurat.View
{
	// Token: 0x02000AAC RID: 2732
	[Token(Token = "0x2000AAC")]
	public class ZigguratView : MainBuildingView<ClanIsle>
	{
		// Token: 0x060041EE RID: 16878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x90A2", Offset = "0x90A2", VA = "0x90A2", Slot = "4")]
		public override void Init(ClanIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_Ziggurat_View_ZigguratView__Init(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a577ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle___ctor__);
		    DAT_ram_00a577ec = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Windows_Buildings_MainBuildingView_ClanIsle___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EF")]
		[Address(RVA = "0x90A3", Offset = "0x90A3", VA = "0x90A3")]
		public ZigguratView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Buildings_Ziggurat_View_ZigguratView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a577ed == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12588);
		    DAT_ram_00a577ed = '\x01';
		  }
		  return StringLiteral_12588;
		}
		*/

		}
	}
}
