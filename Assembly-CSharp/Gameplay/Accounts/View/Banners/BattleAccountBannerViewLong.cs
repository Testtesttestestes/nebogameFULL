using System;
using Il2CppDummyDll;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD2 RID: 3538
	[Token(Token = "0x2000DD2")]
	public class BattleAccountBannerViewLong : BattleAccountBannerView
	{
		// Token: 0x06005648 RID: 22088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005648")]
		[Address(RVA = "0xA3D6", Offset = "0xA3D6", VA = "0xA3D6", Slot = "12")]
		protected override string FormatBacktimeCallback(float value)
		{
		/* --- GHIDRA: FormatBacktimeCallback ---
		void Gameplay_Accounts_View_Banners_BattleAccountBannerViewLong__FormatBacktimeCallback
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_View_Banners_AbstractAccountBannerView_BattleAccount___ctor__
		              );
		    DAT_ram_00a588a1 = '\x01';
		  }
		  Sirenix_Serialization_FormatterEmitter_AOTEmittedFormatter___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_Gameplay_Accounts_View_Banners_AbstractAccountBannerView_BattleAccount___ctor__)
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005649")]
		[Address(RVA = "0xA3D7", Offset = "0xA3D7", VA = "0xA3D7")]
		public BattleAccountBannerViewLong()
		{
		}
	}
}
