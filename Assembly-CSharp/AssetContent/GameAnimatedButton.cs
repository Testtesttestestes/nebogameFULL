using System;
using System.Runtime.CompilerServices;
using Animations;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AssetContent
{
	// Token: 0x02000E27 RID: 3623
	[Token(Token = "0x2000E27")]
	public class GameAnimatedButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IGameAssetContent
	{
		// Token: 0x1400020D RID: 525
		// (add) Token: 0x06005863 RID: 22627 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005864 RID: 22628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020D")]
		public event Action<GameAnimatedButton> ClickEvent
		{
			[Token(Token = "0x6005863")]
			[Address(RVA = "0xA5D1", Offset = "0xA5D1", VA = "0xA5D1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005864")]
			[Address(RVA = "0x1DF5", Offset = "0x1DF5", VA = "0x1DF5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011F8")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x6005865")]
			[Address(RVA = "0xA5D2", Offset = "0xA5D2", VA = "0xA5D2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005866")]
		[Address(RVA = "0xA5D3", Offset = "0xA5D3", VA = "0xA5D3")]
		private SpineUiButtonAnimation GetButtonAnimation()
		{
			return null;
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0000FB10 File Offset: 0x0000DD10
		// (set) Token: 0x06005868 RID: 22632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F9")]
		public bool UseAnimationHitArea
		{
			[Token(Token = "0x6005867")]
			[Address(RVA = "0xA5D4", Offset = "0xA5D4", VA = "0xA5D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005868")]
			[Address(RVA = "0xA5D5", Offset = "0xA5D5", VA = "0xA5D5")]
			set
			{
			}
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005869")]
		[Address(RVA = "0xA5D6", Offset = "0xA5D6", VA = "0xA5D6")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		/* --- GHIDRA: GameAnimationViewOnReadyEvent ---
		void AssetContent_GameAnimatedButton__GameAnimationViewOnReadyEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  float4 local_30;
		  float4 local_2c;
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a63bb9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_IBoundsProvider_TypeInfo);
		    DAT_ram_00a63bb9 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x3c);
		  if ((iVar4 != 0) &&
		     (param1_00 = (int *)func_ii_1082(iVar4,UI_IBoundsProvider_TypeInfo), param1_00 != (int *)0x0))
		  {
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x14),0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (UI_IBoundsProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8236612e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UI_IBoundsProvider_TypeInfo,0);
		code_r0x8236612e:
		    (**(code **)((ulonglong)*puVar3 * 4))(&local_28,param1_00,puVar3[1]);
		    local_8 = local_20;
		    local_38 = local_20;
		    local_10 = local_28;
		    local_40 = local_28;
		    uVar1 = 0;
		    Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar2,&local_40,0);
		    uVar2 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(param1 + 0x14),0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (UI_IBoundsProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x823661ef;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UI_IBoundsProvider_TypeInfo,0);
		code_r0x823661ef:
		    (**(code **)((ulonglong)*puVar3 * 4))(&local_28,param1_00,puVar3[1]);
		    local_8 = local_20;
		    local_10 = local_28;
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (UI_IBoundsProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8236628b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UI_IBoundsProvider_TypeInfo,0);
		code_r0x8236628b:
		    (**(code **)((ulonglong)*puVar3 * 4))(&local_28,param1_00,puVar3[1]);
		    local_8 = local_20;
		    local_30 = (float4)((float)local_1c + (float)local_1c);
		    local_2c = (float4)((float)local_18 + (float)local_18);
		    local_10 = local_28;
		    local_48 = CONCAT44(local_2c,local_30);
		    UnityEngine_RectTransform__get_sizeDelta(uVar2,&local_48,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586A")]
		[Address(RVA = "0xA5D7", Offset = "0xA5D7", VA = "0xA5D7")]
		private void ValidateHitArea()
		{
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600586B RID: 22635 RVA: 0x0000FB28 File Offset: 0x0000DD28
		// (set) Token: 0x0600586C RID: 22636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FA")]
		public bool Enabled
		{
			[Token(Token = "0x600586B")]
			[Address(RVA = "0xA5D8", Offset = "0xA5D8", VA = "0xA5D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600586C")]
			[Address(RVA = "0x1E0C", Offset = "0x1E0C", VA = "0x1E0C")]
			set
			{
			}
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586D")]
		[Address(RVA = "0xA5D9", Offset = "0xA5D9", VA = "0xA5D9")]
		private void ValidateEnabled()
		{
		/* --- GHIDRA: ValidateEnabled ---
		void AssetContent_GameAnimatedButton__ValidateEnabled(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  
		  iVar3 = *(int *)(param1 + 0x10);
		  if (DAT_ram_00a63bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc0 = '\x01';
		  }
		  *(undefined1 *)(iVar3 + 0x1c) = 0;
		  param1_00 = *(int **)(iVar3 + 0x3c);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		          goto code_r0x82366639;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,5);
		code_r0x82366639:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600586E RID: 22638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586E")]
		[Address(RVA = "0xA5DA", Offset = "0xA5DA", VA = "0xA5DA")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void AssetContent_GameAnimatedButton__Awake(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    param1_00 = (int *)0x0;
		    if (DAT_ram_00a63bb7 == '\0') {
		      Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		      DAT_ram_00a63bb7 = '\x01';
		    }
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*piVar2 + 0xb8)) &&
		         (param1_00 = piVar2,
		         *(int *)(*(int *)(*piVar2 + 100) +
		                  (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		         Animations_SpineUiButtonAnimation_TypeInfo)) {
		        param1_00 = (int *)0x0;
		      }
		    }
		    iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		    if (iVar1 != 0) {
		      Animations_SpineUiButtonAnimation__Start(param1_00,param2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600586F RID: 22639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586F")]
		[Address(RVA = "0xA5DB", Offset = "0xA5DB", VA = "0xA5DB", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void AssetContent_GameAnimatedButton__OnPointerClick(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  int *piVar2;
		  
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    param1_00 = (int *)0x0;
		    if (DAT_ram_00a63bb7 == '\0') {
		      Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		      DAT_ram_00a63bb7 = '\x01';
		    }
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*piVar2 + 0xb8)) &&
		         (param1_00 = piVar2,
		         *(int *)(*(int *)(*piVar2 + 100) +
		                  (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		         Animations_SpineUiButtonAnimation_TypeInfo)) {
		        param1_00 = (int *)0x0;
		      }
		    }
		    iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		    if (iVar1 != 0) {
		      Animations_SpineUiButtonAnimation__OnCompleteEvent(param1_00,param2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005870 RID: 22640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005870")]
		[Address(RVA = "0xA5DC", Offset = "0xA5DC", VA = "0xA5DC", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void AssetContent_GameAnimatedButton__OnPointerEnter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  int *piVar2;
		  
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    param1_00 = (int *)0x0;
		    if (DAT_ram_00a63bb7 == '\0') {
		      Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		      DAT_ram_00a63bb7 = '\x01';
		    }
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*piVar2 + 0xb8)) &&
		         (param1_00 = piVar2,
		         *(int *)(*(int *)(*piVar2 + 100) +
		                  (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		         Animations_SpineUiButtonAnimation_TypeInfo)) {
		        param1_00 = (int *)0x0;
		      }
		    }
		    iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		    if (iVar1 != 0) {
		      Animations_SpineUiButtonAnimation__OnPointerEnter(param1_00,param2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005871 RID: 22641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005871")]
		[Address(RVA = "0xA5DD", Offset = "0xA5DD", VA = "0xA5DD", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerExit ---
		undefined4 AssetContent_GameAnimatedButton__OnPointerExit(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x34);
		}
		*/

		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005873 RID: 22643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FB")]
		public string AssetId
		{
			[Token(Token = "0x6005872")]
			[Address(RVA = "0xA5DE", Offset = "0xA5DE", VA = "0xA5DE", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005873")]
			[Address(RVA = "0xA5DF", Offset = "0xA5DF", VA = "0xA5DF", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011FC")]
		public string AssetPath
		{
			[Token(Token = "0x6005874")]
			[Address(RVA = "0xA5E0", Offset = "0xA5E0", VA = "0xA5E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005875")]
		[Address(RVA = "0xA5E1", Offset = "0xA5E1", VA = "0xA5E1")]
		public GameAnimatedButton()
		{
		}

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04002FD8 RID: 12248
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RawImage _rawImage;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x1C")]
		private bool _enabled;

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x1D")]
		private bool _useAnimationHitArea;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: remove_ClickEvent ---
		int * AssetContent_GameAnimatedButton__remove_ClickEvent(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_GameAnimationView ---
		int * AssetContent_GameAnimatedButton__get_GameAnimationView(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  
		  piVar1 = (int *)0x0;
		  if (DAT_ram_00a63bb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    DAT_ram_00a63bb7 = '\x01';
		  }
		  piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (piVar1 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) +
		                (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		       Animations_SpineUiButtonAnimation_TypeInfo)) {
		      piVar1 = (int *)0x0;
		    }
		  }
		  return piVar1;
		}
		*/


		/* --- GHIDRA: get_UseAnimationHitArea ---
		void AssetContent_GameAnimatedButton__get_UseAnimationHitArea
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a63bb8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAnimatedButton_GameAnimationViewOnReadyEvent__);
		    DAT_ram_00a63bb8 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x10);
		  uVar5 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_AssetContent_GameAnimatedButton_GameAnimationViewOnReadyEvent__,0);
		  if (DAT_ram_00a63bbb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bbb = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x10);
		  do {
		    iVar4 = 0;
		    iVar6 = func_ii_7048(iVar3,uVar5,0);
		    uVar2 = System_Action_GameAnimationView__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar4 = func_ii_1082(iVar6,System_Action_GameAnimationView__TypeInfo), iVar4 == 0)) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = func_ii_4329(iVar7 + 0x10,iVar4,iVar3);
		    bVar1 = iVar4 != iVar3;
		    iVar3 = iVar4;
		  } while (bVar1);
		  *(char *)(param1 + 0x1d) = (char)param2;
		  if (param2 != 0) {
		    iVar7 = *(int *)(param1 + 0x10);
		    uVar5 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,Method_AssetContent_GameAnimatedButton_GameAnimationViewOnReadyEvent__,0
		              );
		    if (DAT_ram_00a63bba == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		      DAT_ram_00a63bba = '\x01';
		    }
		    iVar3 = *(int *)(iVar7 + 0x10);
		    do {
		      iVar4 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		      uVar2 = System_Action_GameAnimationView__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar4 = func_ii_1082(iVar6,System_Action_GameAnimationView__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar7 + 0x10,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		    AssetContent_GameAnimatedButton__GameAnimationViewOnReadyEvent(param1,iVar4);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_UseAnimationHitArea ---
		void AssetContent_GameAnimatedButton__set_UseAnimationHitArea
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  int *piVar2;
		  
		  AssetContent_GameAnimatedButton__GameAnimationViewOnReadyEvent(param1,param1);
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a63bb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    DAT_ram_00a63bb7 = '\x01';
		  }
		  piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (param1_00 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) +
		                (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		       Animations_SpineUiButtonAnimation_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Animations_SpineUiButtonAnimation__get_Enabled(param1_00,(uint)*(byte *)(param1 + 0x1c),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Enabled ---
		void AssetContent_GameAnimatedButton__get_Enabled(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  int *piVar2;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a63bb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    DAT_ram_00a63bb7 = '\x01';
		  }
		  piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (param1_00 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) +
		                (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		       Animations_SpineUiButtonAnimation_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Animations_SpineUiButtonAnimation__get_Enabled(param1_00,(uint)*(byte *)(param1 + 0x1c),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetId ---
		void AssetContent_GameAnimatedButton__get_AssetId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_Transform__SetParent(*(undefined4 *)(param1 + 0x10),param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		undefined4 AssetContent_GameAnimatedButton__set_AssetId(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x48);
		}
		*/


		/* --- GHIDRA: get_AssetPath ---
		void AssetContent_GameAnimatedButton__get_AssetPath(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x1c) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

}
