using System;
using System.Collections;
using System.Collections.Generic;
using Core.Animations;
using Cysharp.Threading.Tasks;
using Gameplay.UserInterface.Control;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Windows;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View.UserGotNewLevel
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	public class UserGotNewLevelWindow : ClosableBaseWindow<UserGotNewLevelWindow.UserGotNewLevelWindowArgs>
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D8")]
		public override string WindowId
		{
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x687B", Offset = "0x687B", VA = "0x687B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x170003D9")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x687C", Offset = "0x687C", VA = "0x687C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003DA")]
		public TMP_Text LevelValueField
		{
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x687D", Offset = "0x687D", VA = "0x687D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003DB")]
		public Button GetRewardButton
		{
			[Token(Token = "0x60016BD")]
			[Address(RVA = "0x687E", Offset = "0x687E", VA = "0x687E")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x687F", Offset = "0x687F", VA = "0x687F", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a58274 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_TypeInfo);
		    DAT_ram_00a58274 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs__OnShow__
		              );
		  iVar1 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_TypeInfo
		                               );
		  Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__HandleRatingBtnClickEvent
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x6c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  if (DAT_ram_00a58275 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__StarAnimationRoutine_d__30_TypeInfo
		              );
		    DAT_ram_00a58275 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__StarAnimationRoutine_d__30_TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar1,0,0);
		  *(int *)(iVar1 + 0x10) = param1;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		  if (DAT_ram_00a58276 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ConfettiRoutine_d__31_TypeInfo
		              );
		    DAT_ram_00a58276 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ConfettiRoutine_d__31_TypeInfo
		                    );
		  *(int *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x6880", Offset = "0x6880", VA = "0x6880", Slot = "22")]
		protected override void OnShow(UserGotNewLevelWindow.UserGotNewLevelWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		int Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__OnShow
		              (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58275 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__StarAnimationRoutine_d__30_TypeInfo
		              );
		    DAT_ram_00a58275 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__StarAnimationRoutine_d__30_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = param1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x6881", Offset = "0x6881", VA = "0x6881")]
		private IEnumerator StarAnimationRoutine()
		{
		/* --- GHIDRA: StarAnimationRoutine ---
		int Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__StarAnimationRoutine
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58276 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ConfettiRoutine_d__31_TypeInfo
		              );
		    DAT_ram_00a58276 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ConfettiRoutine_d__31_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x6882", Offset = "0x6882", VA = "0x6882")]
		private IEnumerator ConfettiRoutine()
		{
		/* --- GHIDRA: ConfettiRoutine ---
		int Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ConfettiRoutine
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58277 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowContentRoutine_d__32_TypeInfo
		              );
		    DAT_ram_00a58277 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowContentRoutine_d__32_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x6883", Offset = "0x6883", VA = "0x6883")]
		private IEnumerator ShowContentRoutine()
		{
		/* --- GHIDRA: ShowContentRoutine ---
		int Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowContentRoutine
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58278 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowGetContentRoutine_d__33_TypeInfo
		              );
		    DAT_ram_00a58278 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowGetContentRoutine_d__33_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x6884", Offset = "0x6884", VA = "0x6884")]
		private IEnumerator ShowGetContentRoutine(UniTaskCompletionSource cts)
		{
		/* --- GHIDRA: ShowGetContentRoutine ---
		void Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowGetContentRoutine
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  uint uVar5;
		  int iVar6;
		  double param1_01;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a58279 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SimpleIconValue__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SimpleIconValue___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a58279 = '\x01';
		  }
		  if (0 < *(int *)(param2 + 0xc)) {
		    do {
		      iVar2 = *(int *)(param2 + iVar6 * 4 + 0x10);
		      uVar3 = *(undefined4 *)(param1 + 0x48);
		      uVar4 = *(undefined4 *)(param1 + 0x44);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar3 = func_ii_6805(uVar4,uVar3,Method_UnityEngine_Object_Instantiate_SimpleIconValue___);
		      iVar1 = Method_System_Collections_Generic_List_SimpleIconValue__Add__;
		      param1_00 = *(int *)(param1 + 0x68);
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar5 = *(uint *)(param1_00 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar3;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId
		                (uVar3,*(undefined4 *)(iVar2 + 8),0);
		      param1_01 = *(double *)(iVar2 + 0x10);
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      uVar4 = func_ii_7372(param1_01,0);
		      Utils_StringUtils__GetNumberStringWithSpaces(uVar3,uVar4,0);
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x6885", Offset = "0x6885", VA = "0x6885")]
		public void SetResources(UserGotNewLevelWindow.ResourceRewardData[] values)
		{
		/* --- GHIDRA: SetResources ---
		void Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__SetResources
		               (undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a58277 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowContentRoutine_d__32_TypeInfo
		              );
		    DAT_ram_00a58277 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowContentRoutine_d__32_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x6886", Offset = "0x6886", VA = "0x6886")]
		public void ShowContent()
		{
		/* --- GHIDRA: ShowContent ---
		void Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowContent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5827b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SimpleIconValue___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SimpleIconValue__TypeInfo);
		    DAT_ram_00a5827b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_SimpleIconValue__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_SimpleIconValue___ctor__);
		  *(undefined4 *)(param1 + 0x68) = param1_00;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x1F26", Offset = "0x1F26", VA = "0x1F26")]
		public UniTask ShowGetContent()
		{
			return default(UniTask);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x6887", Offset = "0x6887", VA = "0x6887")]
		public UserGotNewLevelWindow()
		{
		}

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/UserGotNewLevelWindow";

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TMP_Text _levelValueField;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _getRewardButton;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SimpleIconValue _rewardPrefab;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _rewardOwner;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameSpineUiAnimation _scrollAnimation;

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameSpineUiAnimation _starAnimation;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private CanvasGroup _scrollContent;

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ParticleSystem[] _confetti;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _confettiItemStartDelay;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _getRewardItemDelay;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x64")]
		[FormerlySerializedAs("_scrollAfterScrollClosingDelay")]
		[SerializeField]
		private float _scrollAfterClosingDelay;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		public const string ScrollAnimationStateClosed = "01_closed";

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		public const string ScrollAnimationStateOpening = "02_opening";

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		public const string ScrollAnimationStateOpened = "03_opened";

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		public const string ScrollAnimationStateClosing = "04_closing";

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x68")]
		private List<SimpleIconValue> _rewards;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x6C")]
		private UserGotNewLevelWindowViewMediator _mediator;

		// Token: 0x020003CA RID: 970
		[Token(Token = "0x20003CA")]
		public class UserGotNewLevelWindowArgs : BaseWindowArgs
		{
			// Token: 0x060016C8 RID: 5832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016C8")]
			[Address(RVA = "0x6888", Offset = "0x6888", VA = "0x6888")]
			public UserGotNewLevelWindowArgs(UserInterfaceController controller)
			{
			}

			// Token: 0x04000C0E RID: 3086
			[Token(Token = "0x4000C0E")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserInterfaceController UserInterfaceController;
		}

		// Token: 0x020003CB RID: 971
		[Token(Token = "0x20003CB")]
		public class ResourceRewardData
		{
			// Token: 0x060016C9 RID: 5833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016C9")]
			[Address(RVA = "0x1F24", Offset = "0x1F24", VA = "0x1F24")]
			public ResourceRewardData(string assetId, double value)
			{
			}

			// Token: 0x04000C0F RID: 3087
			[Token(Token = "0x4000C0F")]
			[FieldOffset(Offset = "0x8")]
			public readonly string AssetId;

			// Token: 0x04000C10 RID: 3088
			[Token(Token = "0x4000C10")]
			[FieldOffset(Offset = "0x10")]
			public readonly double Value;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GetRewardButton ---
		void Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__get_GetRewardButton
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58273 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs__OnClose__
		              );
		    DAT_ram_00a58273 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x6c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0x134));
		  return;
		}
		*/

}
