using System;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Portals.View.RatingTab
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	public class PortalsRatingView : MonoBehaviour
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000697")]
		public PortalRatingOSAView UsersOSAView
		{
			[Token(Token = "0x600236A")]
			[Address(RVA = "0x74BE", Offset = "0x74BE", VA = "0x74BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000698")]
		public MyPortalRatingView MyRatingView
		{
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x74BF", Offset = "0x74BF", VA = "0x74BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x74C0", Offset = "0x74C0", VA = "0x74C0")]
		public void Init()
		{
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x1BD9", Offset = "0x1BD9", VA = "0x1BD9")]
		public void SetVisibleReceivingData(bool value)
		{
		/* --- GHIDRA: SetVisibleReceivingData ---
		void Gameplay_Portals_View_RatingTab_PortalsRatingView__SetVisibleReceivingData
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  uint uVar3;
		  int param3_00;
		  
		  if (DAT_ram_00a58135 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_ShopItemData_TypeInfo);
		    DAT_ram_00a58135 = '\x01';
		  }
		  param3_00 = *(int *)(param1 + 0x14);
		  uVar2 = Gameplay_Portals_Model_PortalsShopModel__set_AvailableFilters
		                    (param1,*(undefined4 *)(param2 + 0xc),param3_00);
		  param2_00 = unnamed_function_1417(Gameplay_Portals_Model_ShopItemData_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = uVar2;
		  *(int *)(param2_00 + 8) = param2;
		  iVar1 = Method_System_Collections_Generic_List_ShopItemData__Add__;
		  *(int *)(param3_00 + 0x10) = *(int *)(param3_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param3_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param3_00 + 8) + 0xc)) {
		    *(uint *)(param3_00 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param3_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param3_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x74C1", Offset = "0x74C1", VA = "0x74C1")]
		public PortalsRatingView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_RatingTab_PortalsRatingView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5810b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12143);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12142);
		    DAT_ram_00a5810b = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x50);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12142,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x28) = uVar1;
		  iVar2 = *(int *)(param1 + 0x54);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12143,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x28) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PortalRatingOSAView _usersOSAView;

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MyPortalRatingView _myRatingView;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _receivingDataView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MyRatingView ---
		void Gameplay_Portals_View_RatingTab_PortalsRatingView__get_MyRatingView
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5810a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalRatingsViewsHolder__Init__
		              );
		    DAT_ram_00a5810a = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x10),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalRatingsViewsHolder__Init__
		            );
		  return;
		}
		*/

}
