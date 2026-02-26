using System;
using AssetContent;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Portals.View.TotalizatorTab
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	public class PortalsTotalizatorView : MonoBehaviourWithStates<PortalsTotalizatorView.State>
	{
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067E")]
		public PortalsTotalizatorOSAView UsersOSAView
		{
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x7480", Offset = "0x7480", VA = "0x7480")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067F")]
		public ButtonWithCost DoBetButton
		{
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x7481", Offset = "0x7481", VA = "0x7481")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000680")]
		public ButtonWithCost UpdateListButton
		{
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x7482", Offset = "0x7482", VA = "0x7482")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000681")]
		public TextMeshProUGUI BetInfoText
		{
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x7483", Offset = "0x7483", VA = "0x7483")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000682")]
		public TextMeshProUGUI DoBetText
		{
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x7484", Offset = "0x7484", VA = "0x7484")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000683")]
		public TextMeshProUGUI NotEnoughText
		{
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x7485", Offset = "0x7485", VA = "0x7485")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000684")]
		public TextMeshProUGUI BetNumber
		{
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x7486", Offset = "0x7486", VA = "0x7486")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x7487", Offset = "0x7487", VA = "0x7487")]
		public void Init(PortalsModel model)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Portals_View_TotalizatorTab_PortalsTotalizatorView__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State___ctor__);
		    DAT_ram_00a580f7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x7488", Offset = "0x7488", VA = "0x7488")]
		public PortalsTotalizatorView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_TotalizatorTab_PortalsTotalizatorView___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a580f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceLose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceWin__
		              );
		    DAT_ram_00a580f8 = '\x01';
		  }
		  Gameplay_Portals_View_RatingTab_PortalsRatingView___ctor(param1,param1);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceWin__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceLose__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04001348 RID: 4936
		[Token(Token = "0x4001348")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PortalsTotalizatorOSAView _usersOSAView;

		// Token: 0x04001349 RID: 4937
		[Token(Token = "0x4001349")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _doBetButton;

		// Token: 0x0400134A RID: 4938
		[Token(Token = "0x400134A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ButtonWithCost _updateListButton;

		// Token: 0x0400134B RID: 4939
		[Token(Token = "0x400134B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _betInfoText;

		// Token: 0x0400134C RID: 4940
		[Token(Token = "0x400134C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _doBetText;

		// Token: 0x0400134D RID: 4941
		[Token(Token = "0x400134D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _betNumber;

		// Token: 0x0400134E RID: 4942
		[Token(Token = "0x400134E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _notEnoughText;

		// Token: 0x0400134F RID: 4943
		[Token(Token = "0x400134F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _notAvailBanner;

		// Token: 0x020005BC RID: 1468
		[Token(Token = "0x20005BC")]
		public enum State
		{
			// Token: 0x04001351 RID: 4945
			[Token(Token = "0x4001351")]
			UNKNOWN_STATE,
			// Token: 0x04001352 RID: 4946
			[Token(Token = "0x4001352")]
			NEW_BET,
			// Token: 0x04001353 RID: 4947
			[Token(Token = "0x4001353")]
			DO_BET,
			// Token: 0x04001354 RID: 4948
			[Token(Token = "0x4001354")]
			REGISTERED,
			// Token: 0x04001355 RID: 4949
			[Token(Token = "0x4001355")]
			NOT_AVAIL,
			// Token: 0x04001356 RID: 4950
			[Token(Token = "0x4001356")]
			NOT_ENOUGH
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BetNumber ---
		void Gameplay_Portals_View_TotalizatorTab_PortalsTotalizatorView__get_BetNumber
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a580f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalsTotalizatorViewsHolder__Init__
		              );
		    DAT_ram_00a580f6 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x1c),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalsTotalizatorViewsHolder__Init__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x38);
		  uVar1 = Core_Extensions_Dict_PortalDicExt__GetMessage(*(undefined4 *)(param2 + 0x3c),0xdb,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		  return;
		}
		*/

}
