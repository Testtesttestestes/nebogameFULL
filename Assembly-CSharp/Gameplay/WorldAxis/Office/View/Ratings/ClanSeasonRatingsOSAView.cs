using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	public class ClanSeasonRatingsOSAView : OSAGenericBase<ClanSeasonRatingsOSAView.ClansRatingsViewsHolder, ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs>
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x63F9", Offset = "0x63F9", VA = "0x63F9", Slot = "119")]
		protected override ClanSeasonRatingsOSAView.ClansRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ba3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_ClanSeasonRatingsOSAView_ClansRatingsViewsHolder__ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___ctor__
		              );
		    DAT_ram_00a58ba3 = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_ClanSeasonRatingsOSAView_ClansRatingsViewsHolder__ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x63FA", Offset = "0x63FA", VA = "0x63FA")]
		public ClanSeasonRatingsOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58ba4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58ba4 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement__get_Data
		            (*(undefined4 *)(param1 + 0x14),param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x020002FD RID: 765
		[Token(Token = "0x20002FD")]
		public class ClansRatingsViewsHolder : ItemViewsHolder<ClanSeasonRatingsListElement>
		{
			// Token: 0x06001200 RID: 4608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001200")]
			[Address(RVA = "0x63FB", Offset = "0x63FB", VA = "0x63FB", Slot = "13")]
			public override void SetData(GenericListElementArgs args)
			{
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001201")]
			[Address(RVA = "0x63FC", Offset = "0x63FC", VA = "0x63FC")]
			public ClansRatingsViewsHolder()
			{
			}
		}
	}
}
