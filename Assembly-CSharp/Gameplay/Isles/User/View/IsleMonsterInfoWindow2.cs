using System;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UI.Wiki;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1D RID: 3357
	[Token(Token = "0x2000D1D")]
	public class IsleMonsterInfoWindow2 : WindowWhitCloseButton<AttackMonsterWindowArgs>
	{
		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001095")]
		public override string WindowId
		{
			[Token(Token = "0x60051F9")]
			[Address(RVA = "0x9FD0", Offset = "0x9FD0", VA = "0x9FD0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001096")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x60051FA")]
			[Address(RVA = "0x9FD1", Offset = "0x9FD1", VA = "0x9FD1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001097")]
		public MonsterInfoView2 MonsterInfoView
		{
			[Token(Token = "0x60051FB")]
			[Address(RVA = "0x9FD2", Offset = "0x9FD2", VA = "0x9FD2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x17001098")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x60051FC")]
			[Address(RVA = "0x9FD3", Offset = "0x9FD3", VA = "0x9FD3", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x9FD4", Offset = "0x9FD4", VA = "0x9FD4", Slot = "22")]
		protected override void OnShow(AttackMonsterWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Isles_User_View_IsleMonsterInfoWindow2__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,3,0);
		  return;
		}
		*/

		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x9FD5", Offset = "0x9FD5", VA = "0x9FD5")]
		private void CloseAreaEventHandler()
		{
		/* --- GHIDRA: CloseAreaEventHandler ---
		void Gameplay_Isles_User_View_IsleMonsterInfoWindow2__CloseAreaEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar1;
		  
		  if (DAT_ram_00a58d62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleMonsterInfoWindow2_CloseAreaEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_WindowWhitCloseButton_AttackMonsterWindowArgs__OnClose__);
		    DAT_ram_00a58d62 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Isles_User_View_IsleMonsterInfoWindow2_CloseAreaEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  UI_Windows_WindowWhitCloseButton_object___OnClickClose
		            (param1,Method_UI_Windows_WindowWhitCloseButton_AttackMonsterWindowArgs__OnClose__);
		  piVar1 = *(int **)(param1 + 0x44);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x9FD6", Offset = "0x9FD6", VA = "0x9FD6", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Isles_User_View_IsleMonsterInfoWindow2__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_WindowWhitCloseButton_AttackMonsterWindowArgs___ctor__);
		    DAT_ram_00a58d63 = '\x01';
		  }
		  System_Linq_Enumerable_WhereSelectListIterator_JsonParser_JsonValue__Vector3___Where
		            (param1,Method_UI_Windows_WindowWhitCloseButton_AttackMonsterWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x9FD7", Offset = "0x9FD7", VA = "0x9FD7")]
		public IsleMonsterInfoWindow2()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Isles_User_View_IsleMonsterInfoWindow2___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Isles_User_View_MonsterInfoView__get_MonsterDifficultyElement(param1,param1);
		  uVar1 = System_Xml_XmlElement__get_ParentNode(uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IsleMonster/IsleMonsterInfoWindow2";

		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MonsterInfoView2 _monsterInfoView;

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _closeArea;

		// Token: 0x04002C95 RID: 11413
		[Token(Token = "0x4002C95")]
		[FieldOffset(Offset = "0x44")]
		private IsleMonsterInfoWindowMediator2 _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsFullscreenWindow ---
		void Gameplay_Isles_User_View_IsleMonsterInfoWindow2__get_IsFullscreenWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d61 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleMonsterInfoWindow2_CloseAreaEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_WindowWhitCloseButton_AttackMonsterWindowArgs__OnShow__);
		    DAT_ram_00a58d61 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Isles_User_View_IsleMonsterInfoWindow2_CloseAreaEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  UI_Windows_WindowWhitCloseButton_object___OnDestroy
		            (param1,param2,Method_UI_Windows_WindowWhitCloseButton_AttackMonsterWindowArgs__OnShow__
		            );
		  iVar3 = *(int *)(param2 + 0x18);
		  uVar1 = *(undefined4 *)(iVar3 + 0x14);
		  uVar2 = *(undefined4 *)(iVar3 + 0xc);
		  param2_00 = *(undefined4 *)(iVar3 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_TypeInfo
		                               );
		  if (DAT_ram_00a58dc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2___ctor__
		              );
		    DAT_ram_00a58dc1 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,uVar2,uVar1,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2___ctor__
		            );
		  *(int **)(param1 + 0x44) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
