using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	public class InfoArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x170007FA")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A30")]
			[Address(RVA = "0x7AD3", Offset = "0x7AD3", VA = "0x7AD3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x7AD4", Offset = "0x7AD4", VA = "0x7AD4", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_InfoArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a1ad == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_Info_ArtifactInfoPopupWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_AuchanArtifactView___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_ThemeDuelShopItemView___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ArtifactInfoPopupWindow___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_AuchanArtifactInfoPopupWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12565);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12634);
		    DAT_ram_00a5a1ad = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x811de38e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,5);
		code_r0x811de38e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = func_ii_6601(uVar3,Method_UnityEngine_GameObject_GetComponent_AuchanArtifactView___);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x811de41c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,5);
		code_r0x811de41c:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar4 = func_ii_6601(uVar4,Method_UnityEngine_GameObject_GetComponent_ThemeDuelShopItemView___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  if (iVar5 == 0) {
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar5 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		    if (iVar5 == 0) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		      iVar5 = unnamed_function_1417
		                        (Gameplay_Inventory_View_Info_ArtifactInfoPopupWindowArgs_TypeInfo);
		      Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		      *(int **)(iVar5 + 0x18) = param2;
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		            goto code_r0x811de637;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811de637:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      uVar4 = func_ii_7112(uVar4,0);
		      *(undefined4 *)(iVar5 + 0x1c) = uVar4;
		      Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                (uVar3,StringLiteral_12634,iVar5,
		                 Method_UI_Windows_PopupController_Show_ArtifactInfoPopupWindow___);
		      return;
		    }
		  }
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  iVar5 = unnamed_function_1417(Gameplay_Inventory_View_Info_ArtifactInfoPopupWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		  *(int **)(iVar5 + 0x18) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x811de53f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811de53f:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  *(undefined4 *)(iVar5 + 0x1c) = uVar4;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar3,StringLiteral_12565,iVar5,
		             Method_UI_Windows_PopupController_Show_AuchanArtifactInfoPopupWindow___);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x7AD5", Offset = "0x7AD5", VA = "0x7AD5", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x7AD6", Offset = "0x7AD6", VA = "0x7AD6")]
		public InfoArtifactContextMenuElement()
		{
		}
	}
}
