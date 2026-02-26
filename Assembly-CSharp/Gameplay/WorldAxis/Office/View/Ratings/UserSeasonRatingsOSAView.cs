using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	public class UserSeasonRatingsOSAView : OSAGenericBase<UserSeasonRatingsOSAView.UsersRatingsViewsHolder, UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs>
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x6419", Offset = "0x6419", VA = "0x6419", Slot = "119")]
		protected override UserSeasonRatingsOSAView.UsersRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bb1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_UserSeasonRatingsOSAView_UsersRatingsViewsHolder__UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___ctor__
		              );
		    DAT_ram_00a58bb1 = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_UserSeasonRatingsOSAView_UsersRatingsViewsHolder__UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x641A", Offset = "0x641A", VA = "0x641A")]
		public UserSeasonRatingsOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58bb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58bb2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a58bad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__set_args__
		              );
		    DAT_ram_00a58bad = '\x01';
		  }
		  if (*(char *)(param1_00 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1_00,param2,
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__Init__
		              );
		    return;
		  }
		  *(int **)(param1_00 + 0x18) = param2;
		  Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__OnInit
		            (param1_00,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x02000308 RID: 776
		[Token(Token = "0x2000308")]
		public class UsersRatingsViewsHolder : ItemViewsHolder<UserSeasonRatingsListElement>
		{
			// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001220")]
			[Address(RVA = "0x641B", Offset = "0x641B", VA = "0x641B", Slot = "13")]
			public override void SetData(GenericListElementArgs args)
			{
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001221")]
			[Address(RVA = "0x641C", Offset = "0x641C", VA = "0x641C")]
			public UsersRatingsViewsHolder()
			{
			}
		}
	}
}
