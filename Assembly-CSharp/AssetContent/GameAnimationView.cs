using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Animations;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000E28")]
	[DisallowMultipleComponent]
	public class GameAnimationView : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IGrayscalable
	{
		// Token: 0x1400020E RID: 526
		// (add) Token: 0x06005876 RID: 22646 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005877 RID: 22647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020E")]
		public event Action<GameAnimationView> AnimationReadyEvent
		{
			[Token(Token = "0x6005876")]
			[Address(RVA = "0xA5E2", Offset = "0xA5E2", VA = "0xA5E2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005877")]
			[Address(RVA = "0xA5E3", Offset = "0xA5E3", VA = "0xA5E3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400020F RID: 527
		// (add) Token: 0x06005878 RID: 22648 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005879 RID: 22649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020F")]
		public event Action<GameAnimationView> AnimationCompleteEvent
		{
			[Token(Token = "0x6005878")]
			[Address(RVA = "0xA5E4", Offset = "0xA5E4", VA = "0xA5E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005879")]
			[Address(RVA = "0xA5E5", Offset = "0xA5E5", VA = "0xA5E5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000210 RID: 528
		// (add) Token: 0x0600587A RID: 22650 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600587B RID: 22651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000210")]
		public event Action ClickEvent
		{
			[Token(Token = "0x600587A")]
			[Address(RVA = "0xA5E6", Offset = "0xA5E6", VA = "0xA5E6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600587B")]
			[Address(RVA = "0xA5E7", Offset = "0xA5E7", VA = "0xA5E7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000211 RID: 529
		// (add) Token: 0x0600587C RID: 22652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600587D RID: 22653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000211")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x600587C")]
			[Address(RVA = "0xA5E8", Offset = "0xA5E8", VA = "0xA5E8", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x600587D")]
			[Address(RVA = "0xA5E9", Offset = "0xA5E9", VA = "0xA5E9", Slot = "6")]
			remove
			{
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600587E RID: 22654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011FD")]
		public IGameAnimation CurrentAnimation
		{
			[Token(Token = "0x600587E")]
			[Address(RVA = "0xA5EA", Offset = "0xA5EA", VA = "0xA5EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600587F RID: 22655 RVA: 0x0000FB40 File Offset: 0x0000DD40
		// (set) Token: 0x06005880 RID: 22656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FE")]
		public bool IsReady
		{
			[Token(Token = "0x600587F")]
			[Address(RVA = "0xA5EB", Offset = "0xA5EB", VA = "0xA5EB", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005880")]
			[Address(RVA = "0xA5EC", Offset = "0xA5EC", VA = "0xA5EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x0000FB58 File Offset: 0x0000DD58
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FF")]
		public bool Loop
		{
			[Token(Token = "0x6005881")]
			[Address(RVA = "0xA5ED", Offset = "0xA5ED", VA = "0xA5ED")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005882")]
			[Address(RVA = "0xA5EE", Offset = "0xA5EE", VA = "0xA5EE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001200")]
		public string AssetPath
		{
			[Token(Token = "0x6005883")]
			[Address(RVA = "0xA5EF", Offset = "0xA5EF", VA = "0xA5EF", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005884")]
			[Address(RVA = "0xA5F0", Offset = "0xA5F0", VA = "0xA5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x0000FB70 File Offset: 0x0000DD70
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001201")]
		public bool Interactable
		{
			[Token(Token = "0x6005885")]
			[Address(RVA = "0xA5F1", Offset = "0xA5F1", VA = "0xA5F1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005886")]
			[Address(RVA = "0xA5F2", Offset = "0xA5F2", VA = "0xA5F2")]
			set
			{
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x06005888 RID: 22664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001202")]
		public int SortingOrder
		{
			[Token(Token = "0x6005887")]
			[Address(RVA = "0xA5F3", Offset = "0xA5F3", VA = "0xA5F3")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005888")]
			[Address(RVA = "0xA5F4", Offset = "0xA5F4", VA = "0xA5F4")]
			set
			{
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x0600588A RID: 22666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001203")]
		public int SortingLayerId
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0xA5F5", Offset = "0xA5F5", VA = "0xA5F5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600588A")]
			[Address(RVA = "0xA5F6", Offset = "0xA5F6", VA = "0xA5F6")]
			set
			{
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600588B RID: 22667 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600588C RID: 22668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001204")]
		public string AssetId
		{
			[Token(Token = "0x600588B")]
			[Address(RVA = "0xA5F7", Offset = "0xA5F7", VA = "0xA5F7", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600588C")]
			[Address(RVA = "0x1F57", Offset = "0x1F57", VA = "0x1F57", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588D")]
		[Address(RVA = "0xA5F8", Offset = "0xA5F8", VA = "0xA5F8")]
		private void ClearAnimation()
		{
		/* --- GHIDRA: ClearAnimation ---
		void AssetContent_GameAnimationView__ClearAnimation
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  AssetContent_GameAnimationView__get_AssetId(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588E")]
		[Address(RVA = "0xA5F9", Offset = "0xA5F9", VA = "0xA5F9")]
		private void FailCallback(string resourceUrl)
		{
		/* --- GHIDRA: FailCallback ---
		void AssetContent_GameAnimationView__FailCallback
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  float fVar7;
		  int *piVar8;
		  int param1_00;
		  uint uVar9;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a63bc5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAnimationView_CurrentAnimationOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAnimationView_CurrentAnimationOnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Materials_IGrayscalable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63bc5 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1d) != '\0') {
		    uVar9 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x82367105;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x82367105:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar3,0);
		    return;
		  }
		  iVar2 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (param3,*(undefined4 *)(param1 + 0x48),0);
		  if (iVar2 != 0) {
		    return;
		  }
		  *(int **)(param1 + 0x3c) = param2;
		  uVar3 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAnimationView_CurrentAnimationOnClickEvent__,0);
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x823671e0;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,0);
		code_r0x823671e0:
		  (**(code **)((ulonglong)*puVar4 * 4))(param2,uVar3,puVar4[1]);
		  uVar9 = 0;
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0xf0);
		        goto code_r0x8236725e;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x8236725e:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  *(undefined4 *)(param1 + 0x38) = uVar3;
		  uVar3 = UnityEngine_UI_Selectable__set_interactable(uVar3,0);
		  uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  UnityEngine_GameObject___ctor(uVar3,uVar5,0,0);
		  uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x38),0);
		  if (DAT_ram_00a65020 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a65020 = '\x01';
		  }
		  local_20 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  local_18 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		  local_10 = local_20;
		  local_8 = local_18;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_20,0);
		  uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x38),0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  uVar9 = 0;
		  local_28 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_30 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar3,&local_30,0);
		  piVar8 = *(int **)(param1 + 0x3c);
		  uVar3 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_AssetContent_GameAnimationView_CurrentAnimationOnCompleteEvent__,0)
		  ;
		  iVar2 = *piVar8;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x823673e2;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Animations_IGameAnimation_TypeInfo,2);
		code_r0x823673e2:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar3,puVar4[1]);
		  iVar2 = func_ii_4769(*(undefined4 *)(param1 + 0x30),0);
		  piVar8 = *(int **)(param1 + 0x3c);
		  if (iVar2 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x30);
		    cVar1 = *(char *)(param1 + 0x45);
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x130);
		          goto code_r0x8236750c;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Animations_IGameAnimation_TypeInfo,0xe);
		code_r0x8236750c:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar3,cVar1 != '\0',puVar4[1]);
		  }
		  else {
		    cVar1 = *(char *)(param1 + 0x45);
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x82367480;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x82367480:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,cVar1 != '\0',puVar4[1]);
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x38);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar3 = UnityEngine_GameObject__AddComponent(uVar3,0);
		  UnityEngine_GameObject__get_layer(uVar5,uVar3,0);
		  uVar3 = *(undefined4 *)(param1 + 0x2c);
		  if (DAT_ram_00a63bc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc1 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = uVar3;
		  piVar8 = *(int **)(param1 + 0x3c);
		  if (piVar8 != (int *)0x0) {
		    uVar9 = 0;
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x110);
		          goto code_r0x823675d9;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Animations_IGameAnimation_TypeInfo,10);
		code_r0x823675d9:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar3,puVar4[1]);
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  if (DAT_ram_00a63bc2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc2 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  piVar8 = *(int **)(param1 + 0x3c);
		  if (piVar8 != (int *)0x0) {
		    uVar9 = 0;
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x100);
		          goto code_r0x8236768d;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Animations_IGameAnimation_TypeInfo,8);
		code_r0x8236768d:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar3,puVar4[1]);
		  }
		  cVar1 = *(char *)(param1 + 0x1c);
		  if (DAT_ram_00a63bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc0 = '\x01';
		  }
		  *(char *)(param1 + 0x1c) = cVar1;
		  piVar8 = *(int **)(param1 + 0x3c);
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x30) = 0;
		  }
		  else {
		    uVar9 = 0;
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0xe8);
		          goto code_r0x82367757;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Animations_IGameAnimation_TypeInfo,5);
		code_r0x82367757:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,cVar1 != '\0',puVar4[1]);
		    *(undefined4 *)(param1 + 0x30) = 0;
		    iVar2 = Core_Materials_IGrayscalable_TypeInfo;
		    param1_00 = *(int *)(param1 + 0x3c);
		    if (param1_00 != 0) {
		      iVar6 = func_ii_1082(param1_00,Core_Materials_IGrayscalable_TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(param1_00,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(param1 + 0x40) = iVar6;
		      iVar2 = Core_Materials_IGrayscalable_TypeInfo;
		      iVar6 = func_ii_1082(param1_00,Core_Materials_IGrayscalable_TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(param1_00,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      goto code_r0x823677c5;
		    }
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		code_r0x823677c5:
		  if (*(char *)(param1 + 0x20) != '\0') {
		    piVar8 = *(int **)(param1 + 0x40);
		    uVar9 = 0;
		    fVar7 = System_Nullable_float___get_HasValue
		                      (param1 + 0x20,Method_System_Nullable_float__get_Value__);
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Materials_IGrayscalable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82367859;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Materials_IGrayscalable_TypeInfo,0);
		code_r0x82367859:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,fVar7,puVar4[1]);
		  }
		  *(undefined1 *)(param1 + 0x44) = 1;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588F")]
		[Address(RVA = "0xA5FA", Offset = "0xA5FA", VA = "0xA5FA")]
		private void CompleteCallback(IGameAnimation iGameAnimation, string resourceUrl)
		{
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005890")]
		[Address(RVA = "0xA5FB", Offset = "0xA5FB", VA = "0xA5FB")]
		private void CurrentAnimationOnCompleteEvent(IGameAnimation obj)
		{
		/* --- GHIDRA: CurrentAnimationOnCompleteEvent ---
		void AssetContent_GameAnimationView__CurrentAnimationOnCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005891")]
		[Address(RVA = "0xA5FC", Offset = "0xA5FC", VA = "0xA5FC")]
		private void CurrentAnimationOnClickEvent(IGameAnimation obj)
		{
		/* --- GHIDRA: CurrentAnimationOnClickEvent ---
		void AssetContent_GameAnimationView__CurrentAnimationOnClickEvent(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x1d) == '\0') {
		    *(undefined1 *)(param1 + 0x1d) = 1;
		    AssetContent_GameAnimationView__get_AssetId(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005892 RID: 22674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005892")]
		[Address(RVA = "0xA5FD", Offset = "0xA5FD", VA = "0xA5FD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void AssetContent_GameAnimationView__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a63bc6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc6 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x3c);
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x30) = param2;
		    return;
		  }
		  uVar2 = 0;
		  cVar1 = *(char *)(param1 + 0x45);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0x130);
		        goto code_r0x82367974;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,0xe);
		code_r0x82367974:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param2,cVar1 != '\0',puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005893")]
		[Address(RVA = "0xA5FE", Offset = "0xA5FE", VA = "0xA5FE")]
		public void PlayAnimation(string state)
		{
		/* --- GHIDRA: PlayAnimation ---
		void AssetContent_GameAnimationView__PlayAnimation(int param1,float param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float fVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63bc7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Materials_IGrayscalable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__get_Value__);
		    DAT_ram_00a63bc7 = '\x01';
		  }
		  local_8 = 0;
		  System_Type__GetProperty(&local_8,param2,Method_System_Nullable_float___ctor__);
		  *(undefined8 *)(param1 + 0x20) = local_8;
		  if (*(char *)(param1 + 0x44) != '\0') {
		    param1_00 = *(int **)(param1 + 0x40);
		    uVar1 = 0;
		    fVar2 = System_Nullable_float___get_HasValue
		                      (param1 + 0x20,Method_System_Nullable_float__get_Value__);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Materials_IGrayscalable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82367a7d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Materials_IGrayscalable_TypeInfo,0);
		code_r0x82367a7d:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,fVar2,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005894")]
		[Address(RVA = "0xA5FF", Offset = "0xA5FF", VA = "0xA5FF", Slot = "10")]
		public void SetGrayscale(float value)
		{
		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAnimationView__SetGrayscale(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x45) = 1;
		  *(undefined1 *)(param1 + 0x1c) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005895")]
		[Address(RVA = "0xA600", Offset = "0xA600", VA = "0xA600")]
		public GameAnimationView()
		{
		}

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x1C")]
		private bool _interactable;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x1D")]
		private bool _isDestroyed;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x20")]
		private float? _grayscale;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x28")]
		private int _sortingLayerId;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x2C")]
		private int _sortingOrder;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x30")]
		private string _animationState;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x34")]
		private string _assetId;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _currentAnimationGameObject;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x3C")]
		private IGameAnimation _currentAnimation;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x40")]
		private IGrayscalable _grayscalable;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: remove_AnimationReadyEvent ---
		void AssetContent_GameAnimationView__remove_AnimationReadyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bbc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bbc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GameAnimationView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimationView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_AnimationCompleteEvent ---
		void AssetContent_GameAnimationView__add_AnimationCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bbd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bbd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GameAnimationView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimationView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_AnimationCompleteEvent ---
		void AssetContent_GameAnimationView__remove_AnimationCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63bbe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bbe = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickEvent ---
		void AssetContent_GameAnimationView__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63bbf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bbf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickEvent ---
		void AssetContent_GameAnimationView__remove_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bba = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GameAnimationView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimationView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ReadyEvent ---
		void AssetContent_GameAnimationView__add_ReadyEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bbb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    DAT_ram_00a63bbb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GameAnimationView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimationView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Interactable ---
		void AssetContent_GameAnimationView__get_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc0 = '\x01';
		  }
		  *(char *)(param1 + 0x1c) = (char)param2;
		  param1_00 = *(int **)(param1 + 0x3c);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		          goto code_r0x823666ec;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,5);
		code_r0x823666ec:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_SortingOrder ---
		void AssetContent_GameAnimationView__get_SortingOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63bc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc1 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  param1_00 = *(int **)(param1 + 0x3c);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		          goto code_r0x82366f58;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,10);
		code_r0x82366f58:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_SortingLayerId ---
		void AssetContent_GameAnimationView__get_SortingLayerId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63bc2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc2 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = param2;
		  param1_00 = *(int **)(param1 + 0x3c);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		          goto code_r0x8236700b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,8);
		code_r0x8236700b:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetId ---
		void AssetContent_GameAnimationView__get_AssetId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a63bc4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAnimationView_CurrentAnimationOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAnimationView_CurrentAnimationOnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63bc4 = '\x01';
		  }
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0x48),0);
		  if (iVar2 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x48);
		    if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		    }
		    Core_GameResources_GameResourcesManager__GetAnimation(uVar3,0);
		  }
		  *(undefined4 *)(param1 + 0x48) = 0;
		  *(undefined4 *)(param1 + 0x34) = 0;
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x38),0);
		  if (iVar2 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x38);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar3,0);
		  }
		  piVar5 = *(int **)(param1 + 0x3c);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_AssetContent_GameAnimationView_CurrentAnimationOnClickEvent__,0);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x82366bef;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Animations_IGameAnimation_TypeInfo,1);
		code_r0x82366bef:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 0x3c);
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_AssetContent_GameAnimationView_CurrentAnimationOnCompleteEvent__,
		               0);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		          goto code_r0x82366c91;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Animations_IGameAnimation_TypeInfo,3);
		code_r0x82366c91:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar3,puVar4[1]);
		  }
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		void AssetContent_GameAnimationView__set_AssetId
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined1 auStack_40 [12];
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a638b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Sprite__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Sprite__Start_Skin__GetSprite_d__16___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Sprite__get_Task__
		              );
		    DAT_ram_00a638b7 = '\x01';
		  }
		  local_4 = 0;
		  local_1c = 0;
		  local_c = 0;
		  local_24 = 0;
		  local_28 = 0xffffffff;
		  local_18 = param2;
		  local_14 = param4;
		  local_10 = param3;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Sprite__Start_Skin__GetSprite_d__16___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Sprite__Start_Skin__GetSprite_d__16___
		              );
		  }
		  Core_Gameplay_Managers_Skins_Skin___c__DisplayClass13_0___GetAtlas_b__1(&local_28,auStack_40);
		  unnamed_function_126403
		            (&local_34,&local_24,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Sprite__get_Task__
		            );
		  *(undefined4 *)(param1 + 1) = local_2c;
		  *param1 = local_34;
		  return;
		}
		*/

}
