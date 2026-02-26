using System;
using Core.Application.Update.Common;
using Core.Gameplay;
using Gameplay.UserInterface.View.Update;
using Il2CppDummyDll;
using UI;
using UI.Windows;
using UnityEngine.EventSystems;

namespace Core.Application.Update
{
	// Token: 0x02001237 RID: 4663
	[Token(Token = "0x2001237")]
	public class AppUpdateRecommended : AbstractAppUpdateRecommended
	{
		// Token: 0x06006EAD RID: 28333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAD")]
		[Address(RVA = "0xB931", Offset = "0xB931", VA = "0xB931")]
		public AppUpdateRecommended(IApp app, IAuthDataProvider authDataProvider, RecommendedAppUpdateView entryPointView, IProgress progressView)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Update_AppUpdateRecommended___ctor(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a800 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Application_Update_AppUpdateRecommended_EntryPointViewOnOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a5a800 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8))
		      {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81279844;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x81279844:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  bVar1 = *(byte *)(iVar5 + 0x28);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)bVar1,0);
		  if (bVar1 != 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Core_Application_Update_AppUpdateRecommended_EntryPointViewOnOnClickEvent__,0)
		    ;
		    Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAE")]
		[Address(RVA = "0xB932", Offset = "0xB932", VA = "0xB932", Slot = "7")]
		public override void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Application_Update_AppUpdateRecommended__Run(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a801 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Application_Update_AppUpdateRecommended_EntryPointViewOnOnClickEvent__);
		    DAT_ram_00a5a801 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Application_Update_AppUpdateRecommended_EntryPointViewOnOnClickEvent__,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAF")]
		[Address(RVA = "0xB933", Offset = "0xB933", VA = "0xB933", Slot = "8")]
		public override void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Application_Update_AppUpdateRecommended__Stop
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Application_Update_Common_AbstractAppUpdateRecommended___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB0")]
		[Address(RVA = "0xB934", Offset = "0xB934", VA = "0xB934")]
		private void EntryPointViewOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB1")]
		[Address(RVA = "0xB935", Offset = "0xB935", VA = "0xB935", Slot = "10")]
		protected override void ConfirmAboutRecommendedAppUpdateCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		/* --- GHIDRA: ConfirmAboutRecommendedAppUpdateCallback ---
		void Core_Application_Update_AppUpdateRecommended__ConfirmAboutRecommendedAppUpdateCallback
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Application_Update_Common_AbstractAppUpdateRequired__Dispose(param1,param1);
		  return;
		}
		*/

		}
	}
}
