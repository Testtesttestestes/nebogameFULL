using System;
using System.Collections.Generic;
using Core.Sorting;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;
using UI.Sorting;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	public class AuchanSortingFilter : AbstractSortControlView<AuchanArtifactData>
	{
		// Token: 0x06004E40 RID: 20032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E40")]
		[Address(RVA = "0x9C72", Offset = "0x9C72", VA = "0x9C72", Slot = "4")]
		protected override List<IGameDataComparer<AuchanArtifactData>> GetComparers()
		{
		/* --- GHIDRA: GetComparers ---
		void Gameplay_Auchan_View_AuchanSortingFilter__GetComparers(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59854 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData___ctor__);
		    DAT_ram_00a59854 = '\x01';
		  }
		  UI_SkinsV2_AbstractSkinResolver___Il2CppFullySharedGenericType__object___StartRollback
		            (param1,Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E41")]
		[Address(RVA = "0x9C73", Offset = "0x9C73", VA = "0x9C73")]
		public AuchanSortingFilter()
		{
		}
	}
}
