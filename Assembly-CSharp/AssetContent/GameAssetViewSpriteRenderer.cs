using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core;
using Core.Materials;
using DG.Tweening;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2B RID: 3627
	[Token(Token = "0x2000E2B")]
	[DisallowMultipleComponent]
	public class GameAssetViewSpriteRenderer : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IBoundsProvider, IGuideTargetResolveEventProvider, IGrayscalable
	{
		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001211")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x60058BE")]
			[Address(RVA = "0xA628", Offset = "0xA628", VA = "0xA628")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060058BF RID: 22719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001212")]
		public SpriteRenderer SpriteRenderer
		{
			[Token(Token = "0x60058BF")]
			[Address(RVA = "0xA629", Offset = "0xA629", VA = "0xA629")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000214 RID: 532
		// (add) Token: 0x060058C0 RID: 22720 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058C1 RID: 22721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000214")]
		public event Action<GameAssetViewSpriteRenderer> ClickedEvent
		{
			[Token(Token = "0x60058C0")]
			[Address(RVA = "0xA62A", Offset = "0xA62A", VA = "0xA62A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058C1")]
			[Address(RVA = "0xA62B", Offset = "0xA62B", VA = "0xA62B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x17001213")]
		public bool IsReady
		{
			[Token(Token = "0x60058C2")]
			[Address(RVA = "0xA62C", Offset = "0xA62C", VA = "0xA62C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000215 RID: 533
		// (add) Token: 0x060058C3 RID: 22723 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058C4 RID: 22724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000215")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x60058C3")]
			[Address(RVA = "0xA62D", Offset = "0xA62D", VA = "0xA62D", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058C4")]
			[Address(RVA = "0xA62E", Offset = "0xA62E", VA = "0xA62E", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0xA62F", Offset = "0xA62F", VA = "0xA62F")]
		private void Awake()
		{
		/* --- GHIDRA: <GrayscaleChanged>b__27_0 ---
		void AssetContent_GameAssetViewSpriteRenderer___GrayscaleChanged_b__27_0
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *param3_00;
		  int *param1_00;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63be6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Collider2D___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_GameAnimationView___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Renderer___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63be6 = '\x01';
		  }
		  uVar2 = func_ii_6601(param2,Method_UnityEngine_GameObject_GetComponent_Collider2D___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar3 == 0) {
		    uVar2 = func_ii_6601(param2,Method_UnityEngine_GameObject_GetComponent_Renderer___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = func_ii_3812(uVar2,0,0);
		    if (iVar3 == 0) {
		      UnityEngine_Renderer__set_useLightProbes(&local_18,uVar2,0);
		      param1[2] = local_8;
		      param1[1] = local_10;
		      *param1 = local_18;
		    }
		    else {
		      iVar3 = func_ii_6601(param2,Method_UnityEngine_GameObject_GetComponent_GameAnimationView___);
		      param1_00 = *(int **)(iVar3 + 0x3c);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Animations_IGameAnimation_TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0
		                                );
		            goto code_r0x8236ae19;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      param3_00 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x8236ae19:
		      uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar2,0);
		      AssetContent_GameAssetViewSpriteRenderer___GrayscaleChanged_b__27_0(&local_18,uVar2,param3_00)
		      ;
		      param1[2] = local_8;
		      param1[1] = local_10;
		      *param1 = local_18;
		    }
		  }
		  else {
		    UnityEngine_Collider2D__set_offset(&local_18,uVar2,0);
		    param1[2] = local_8;
		    param1[1] = local_10;
		    *param1 = local_18;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0xA630", Offset = "0xA630", VA = "0xA630")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0xA631", Offset = "0xA631", VA = "0xA631")]
		private void GameSpriteRendererLoaderInteractableOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001214")]
		public string AssetId
		{
			[Token(Token = "0x60058C8")]
			[Address(RVA = "0xA632", Offset = "0xA632", VA = "0xA632", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058C9")]
			[Address(RVA = "0xA633", Offset = "0xA633", VA = "0xA633", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001215")]
		public string AssetPath
		{
			[Token(Token = "0x60058CA")]
			[Address(RVA = "0xA634", Offset = "0xA634", VA = "0xA634", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0xA635", Offset = "0xA635", VA = "0xA635")]
		public void SetGrayscale(float value, float duration)
		{
		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAssetViewSpriteRenderer__SetGrayscale
		               (int *param1,float param2,float param3,float param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a63be1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewSpriteRenderer__GrayscaleChanged_b__27_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Tweener___);
		    DAT_ram_00a63be1 = '\x01';
		  }
		  if (param1[0xb] != 0) {
		    func_ii_7891(param1[0xb],0,0);
		  }
		  if (0.0 < param4) {
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_float__TypeInfo);
		    DG_Tweening_TweenCallback_int___Invoke(uVar1,param1,*(undefined4 *)(*param1 + 0x134),0);
		    uVar1 = DG_Tweening_DOTween___c__DisplayClass67_0___To_b__1(param2,param3,param4,uVar1,0);
		    param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (param1_00,param1,
		               Method_AssetContent_GameAssetViewSpriteRenderer__GrayscaleChanged_b__27_0__,0);
		    iVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                      (uVar1,param1_00,
		                       Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Tweener___);
		    param1[0xb] = iVar2;
		    return;
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__HandleSpriteChanged(param1[4],param3,param1);
		  AssetContent_GameAnimationView__PlayAnimation(param1[5],param3,param1);
		  return;
		}
		*/

		/* --- GHIDRA: SetGrayscale ---
		void AssetContent_GameAssetViewSpriteRenderer__SetGrayscale
		               (int *param1,float param2,float param3,float param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a63be1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewSpriteRenderer__GrayscaleChanged_b__27_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Tweener___);
		    DAT_ram_00a63be1 = '\x01';
		  }
		  if (param1[0xb] != 0) {
		    func_ii_7891(param1[0xb],0,0);
		  }
		  if (0.0 < param4) {
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_float__TypeInfo);
		    DG_Tweening_TweenCallback_int___Invoke(uVar1,param1,*(undefined4 *)(*param1 + 0x134),0);
		    uVar1 = DG_Tweening_DOTween___c__DisplayClass67_0___To_b__1(param2,param3,param4,uVar1,0);
		    param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (param1_00,param1,
		               Method_AssetContent_GameAssetViewSpriteRenderer__GrayscaleChanged_b__27_0__,0);
		    iVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                      (uVar1,param1_00,
		                       Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Tweener___);
		    param1[0xb] = iVar2;
		    return;
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__HandleSpriteChanged(param1[4],param3,param1);
		  AssetContent_GameAnimationView__PlayAnimation(param1[5],param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0xA636", Offset = "0xA636", VA = "0xA636")]
		private void GrayscaleChanged(float from, float to, float duration)
		{
		/* --- GHIDRA: GrayscaleChanged ---
		void AssetContent_GameAssetViewSpriteRenderer__GrayscaleChanged(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a63be2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnReadyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnReadyEvent__
		              );
		    DAT_ram_00a63be2 = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x2c),0,0);
		  }
		  iVar8 = *(int *)(param1 + 0x14);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnClickEvent__,0);
		  if (DAT_ram_00a63bbf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bbf = '\x01';
		  }
		  iVar3 = *(int *)(iVar8 + 0x18);
		  while ((piVar5 = (int *)func_ii_7048(iVar3,uVar4,0), piVar5 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar5))) {
		    iVar6 = func_ii_4329(iVar8 + 0x18,piVar5,iVar3);
		    bVar1 = iVar6 == iVar3;
		    iVar3 = iVar6;
		    if (bVar1) {
		      iVar8 = *(int *)(param1 + 0x10);
		      uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar4,param1,
		                 Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnClickEvent__
		                 ,0);
		      if (DAT_ram_00a63c03 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a63c03 = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x34);
		      while ((piVar5 = (int *)func_ii_7048(iVar3,uVar4,0), piVar5 == (int *)0x0 ||
		             (System_Action_TypeInfo == *piVar5))) {
		        iVar6 = func_ii_4329(iVar8 + 0x34,piVar5,iVar3);
		        bVar1 = iVar6 == iVar3;
		        iVar3 = iVar6;
		        if (bVar1) {
		          iVar8 = *(int *)(param1 + 0x14);
		          uVar4 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		          UnityEngine_UIElements_VisualElement__get_layout
		                    (uVar4,param1,
		                     Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnReadyEvent__
		                     ,0);
		          if (DAT_ram_00a63bbb == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		            DAT_ram_00a63bbb = '\x01';
		          }
		          iVar3 = *(int *)(iVar8 + 0x10);
		          while( true ) {
		            iVar6 = 0;
		            iVar7 = func_ii_7048(iVar3,uVar4,0);
		            uVar2 = System_Action_GameAnimationView__TypeInfo;
		            if ((iVar7 != 0) &&
		               (iVar6 = func_ii_1082(iVar7,System_Action_GameAnimationView__TypeInfo), iVar6 == 0))
		            break;
		            iVar6 = func_ii_4329(iVar8 + 0x10,iVar6,iVar3);
		            bVar1 = iVar6 == iVar3;
		            iVar3 = iVar6;
		            if (bVar1) {
		              iVar8 = *(int *)(param1 + 0x10);
		              uVar4 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		              UnityEngine_UIElements_VisualElement__get_layout
		                        (uVar4,param1,
		                         Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnReadyEvent__
		                         ,0);
		              if (DAT_ram_00a63bfa == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		                DAT_ram_00a63bfa = '\x01';
		              }
		              iVar3 = *(int *)(iVar8 + 0x14);
		              while( true ) {
		                iVar6 = 0;
		                iVar7 = func_ii_7048(iVar3,uVar4,0);
		                uVar2 = System_Action_IAsyncLoadableContent__TypeInfo;
		                if ((iVar7 != 0) &&
		                   (iVar6 = func_ii_1082(iVar7,System_Action_IAsyncLoadableContent__TypeInfo),
		                   iVar6 == 0)) break;
		                iVar6 = func_ii_4329(iVar8 + 0x14,iVar6,iVar3);
		                bVar1 = iVar6 == iVar3;
		                iVar3 = iVar6;
		                if (bVar1) {
		                  *(undefined4 *)(param1 + 0x3c) = 0;
		                  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(param1,0,iVar6);
		                  *(undefined4 *)(param1 + 0x24) = 0;
		                  return;
		                }
		              }
		              System_Activator__CreateInstance(iVar7,uVar2);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(iVar7,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0xA637", Offset = "0xA637", VA = "0xA637")]
		private void OnDestroy()
		{
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x060058CF RID: 22735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001216")]
		public int SortingOrder
		{
			[Token(Token = "0x60058CE")]
			[Address(RVA = "0xA638", Offset = "0xA638", VA = "0xA638")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60058CF")]
			[Address(RVA = "0x1DF0", Offset = "0x1DF0", VA = "0x1DF0")]
			set
			{
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001217")]
		public int SortingLayerId
		{
			[Token(Token = "0x60058D0")]
			[Address(RVA = "0xA639", Offset = "0xA639", VA = "0xA639")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60058D1")]
			[Address(RVA = "0x1DF2", Offset = "0x1DF2", VA = "0x1DF2")]
			set
			{
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001218")]
		public bool Interactable
		{
			[Token(Token = "0x60058D2")]
			[Address(RVA = "0xA63A", Offset = "0xA63A", VA = "0xA63A")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058D3")]
			[Address(RVA = "0xA63B", Offset = "0xA63B", VA = "0xA63B")]
			set
			{
			}
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0xA63C", Offset = "0xA63C", VA = "0xA63C")]
		private void GameAnimationViewOnClickEvent()
		{
		/* --- GHIDRA: GameAnimationViewOnClickEvent ---
		void AssetContent_GameAssetViewSpriteRenderer__GameAnimationViewOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0xA63D", Offset = "0xA63D", VA = "0xA63D")]
		private void GameSpriteRendererLoaderInteractableOnClickEvent()
		{
		/* --- GHIDRA: GameSpriteRendererLoaderInteractableOnClickEvent ---
		uint AssetContent_GameAssetViewSpriteRenderer__GameSpriteRendererLoaderInteractableOnClickEvent
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  *param3 = 0;
		  if (*(int *)(param2 + 0x10) == 1) {
		    piVar1 = (int *)(param1 + 0x10);
		  }
		  else {
		    if (*(int *)(param2 + 0x10) != 2) {
		      return 0;
		    }
		    piVar1 = (int *)(param1 + 0x14);
		  }
		  iVar2 = *piVar1;
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0xA63E", Offset = "0xA63E", VA = "0xA63E")]
		public bool TryGetCurrentContent(AssetDic asset, out IGameAssetContent content)
		{
		/* --- GHIDRA: TryGetCurrentContent ---
		void AssetContent_GameAssetViewSpriteRenderer__TryGetCurrentContent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63be3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a63be3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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

			return default(bool);
		}

		// Token: 0x14000216 RID: 534
		// (add) Token: 0x060058D7 RID: 22743 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058D8 RID: 22744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000216")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x60058D7")]
			[Address(RVA = "0xA63F", Offset = "0xA63F", VA = "0xA63F", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058D8")]
			[Address(RVA = "0xA640", Offset = "0xA640", VA = "0xA640", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060058D9 RID: 22745 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x17001219")]
		public Bounds Bounds
		{
			[Token(Token = "0x60058D9")]
			[Address(RVA = "0xA641", Offset = "0xA641", VA = "0xA641", Slot = "10")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0xA642", Offset = "0xA642", VA = "0xA642")]
		public void TestGrayscale(float value, float duration)
		{
		/* --- GHIDRA: TestGrayscale ---
		void AssetContent_GameAssetViewSpriteRenderer__TestGrayscale
		               (int param1,float param2,undefined4 param3)
		
		{
		  AssetContent_Loaders_GameSpriteRendererLoader__HandleSpriteChanged
		            (*(undefined4 *)(param1 + 0x10),param2,param1);
		  AssetContent_GameAnimationView__PlayAnimation(*(undefined4 *)(param1 + 0x14),param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0xA643", Offset = "0xA643", VA = "0xA643", Slot = "14")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0xA644", Offset = "0xA644", VA = "0xA644")]
		public GameAssetViewSpriteRenderer()
		{
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60058DD")]
		[Address(RVA = "0xA645", Offset = "0xA645", VA = "0xA645", Slot = "13")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpriteRendererLoaderInteractable _gameSpriteRendererLoaderInteractable;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x20")]
		private string _assetId;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x24")]
		private AssetDic _asset;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x28")]
		private float _grayscaleValue;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x2C")]
		private Tween _grayscaleTween;

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x30")]
		private int _sortingOrder;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x34")]
		private int _sortingLayerId;

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x38")]
		private bool _interactable;

		// Token: 0x02000E2C RID: 3628
		[Token(Token = "0x2000E2C")]
		public static class BoundsFromGASR
		{
			// Token: 0x060058DF RID: 22751 RVA: 0x0000FD08 File Offset: 0x0000DF08
			[Token(Token = "0x60058DF")]
			[Address(RVA = "0xA647", Offset = "0xA647", VA = "0xA647")]
			public static Bounds GetBounds(GameObject gameObject)
			{
				return default(Bounds);
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GameAnimationView ---
		undefined4
		AssetContent_GameAssetViewSpriteRenderer__get_GameAnimationView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x10);
		  if (DAT_ram_00a63bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    DAT_ram_00a63bfc = '\x01';
		  }
		  if (*(int *)(param1_00 + 0x2c) != 0) {
		    return *(undefined4 *)(param1_00 + 0x2c);
		  }
		  uVar1 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		  *(undefined4 *)(param1_00 + 0x2c) = uVar1;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_SpriteRenderer ---
		void AssetContent_GameAssetViewSpriteRenderer__get_SpriteRenderer
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bda == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    DAT_ram_00a63bda = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GameAssetViewSpriteRenderer__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAssetViewSpriteRenderer__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickedEvent ---
		void AssetContent_GameAssetViewSpriteRenderer__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bdb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    DAT_ram_00a63bdb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GameAssetViewSpriteRenderer__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAssetViewSpriteRenderer__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickedEvent ---
		uint AssetContent_GameAssetViewSpriteRenderer__remove_ClickedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (*(char *)(*(int *)(param1 + 0x14) + 0x44) == '\0') {
		    uVar1 = (uint)(*(char *)(*(int *)(param1 + 0x10) + 0x30) != '\0');
		  }
		  else {
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsReady ---
		void AssetContent_GameAssetViewSpriteRenderer__get_IsReady
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bdc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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
		void AssetContent_GameAssetViewSpriteRenderer__add_ReadyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bdd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a63bdd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ReadyEvent ---
		void AssetContent_GameAssetViewSpriteRenderer__remove_ReadyEvent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  
		  if (DAT_ram_00a63bde == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnReadyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnReadyEvent__
		              );
		    DAT_ram_00a63bde = '\x01';
		  }
		  iVar9 = *(int *)(param1 + 0x10);
		  if (DAT_ram_00a63bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    DAT_ram_00a63bfc = '\x01';
		  }
		  if (*(int *)(iVar9 + 0x2c) == 0) {
		    uVar4 = func_ii_5677(iVar9,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(iVar9 + 0x2c) = uVar4;
		  }
		  else {
		    uVar4 = *(undefined4 *)(iVar9 + 0x2c);
		  }
		  iVar9 = *(int *)(param1 + 0x14);
		  uVar5 = UnityEngine_Renderer__set_sortingLayerName(uVar4,0);
		  if (DAT_ram_00a63bc2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc2 = '\x01';
		  }
		  *(undefined4 *)(iVar9 + 0x28) = uVar5;
		  piVar10 = *(int **)(iVar9 + 0x3c);
		  if (piVar10 != (int *)0x0) {
		    uVar2 = 0;
		    iVar9 = *piVar10;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8))
		        {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0x100);
		          goto code_r0x82369458;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar10,Core_Animations_IGameAnimation_TypeInfo,8);
		code_r0x82369458:
		    (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar5,puVar6[1]);
		  }
		  iVar9 = *(int *)(param1 + 0x14);
		  uVar4 = UnityEngine_Renderer__get_sortingLayerID(uVar4,0);
		  if (DAT_ram_00a63bc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc1 = '\x01';
		  }
		  *(undefined4 *)(iVar9 + 0x2c) = uVar4;
		  piVar10 = *(int **)(iVar9 + 0x3c);
		  if (piVar10 != (int *)0x0) {
		    uVar2 = 0;
		    iVar9 = *piVar10;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8))
		        {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0x110);
		          goto code_r0x82369516;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar10,Core_Animations_IGameAnimation_TypeInfo,10);
		code_r0x82369516:
		    (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar4,puVar6[1]);
		  }
		  iVar9 = *(int *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnClickEvent__
		             ,0);
		  if (DAT_ram_00a63c02 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63c02 = '\x01';
		  }
		  iVar3 = *(int *)(iVar9 + 0x34);
		  while ((piVar10 = (int *)UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0), piVar10 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar10))) {
		    iVar7 = func_ii_4329(iVar9 + 0x34,piVar10,iVar3);
		    bVar1 = iVar7 == iVar3;
		    iVar3 = iVar7;
		    if (bVar1) {
		      iVar9 = *(int *)(param1 + 0x14);
		      uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar4,param1,
		                 Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnClickEvent__,0);
		      if (DAT_ram_00a63bbe == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a63bbe = '\x01';
		      }
		      iVar3 = *(int *)(iVar9 + 0x18);
		      while ((piVar10 = (int *)UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0),
		             piVar10 == (int *)0x0 || (System_Action_TypeInfo == *piVar10))) {
		        iVar7 = func_ii_4329(iVar9 + 0x18,piVar10,iVar3);
		        bVar1 = iVar7 == iVar3;
		        iVar3 = iVar7;
		        if (bVar1) {
		          iVar9 = *(int *)(param1 + 0x14);
		          uVar4 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		          UnityEngine_UIElements_VisualElement__get_layout
		                    (uVar4,param1,
		                     Method_AssetContent_GameAssetViewSpriteRenderer_GameAnimationViewOnReadyEvent__
		                     ,0);
		          if (DAT_ram_00a63bba == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		            DAT_ram_00a63bba = '\x01';
		          }
		          iVar3 = *(int *)(iVar9 + 0x10);
		          while( true ) {
		            iVar7 = 0;
		            iVar8 = UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0);
		            uVar5 = System_Action_GameAnimationView__TypeInfo;
		            if ((iVar8 != 0) &&
		               (iVar7 = func_ii_1082(iVar8,System_Action_GameAnimationView__TypeInfo), iVar7 == 0))
		            break;
		            iVar7 = func_ii_4329(iVar9 + 0x10,iVar7,iVar3);
		            bVar1 = iVar7 == iVar3;
		            iVar3 = iVar7;
		            if (bVar1) {
		              iVar9 = *(int *)(param1 + 0x10);
		              uVar4 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		              UnityEngine_UIElements_VisualElement__get_layout
		                        (uVar4,param1,
		                         Method_AssetContent_GameAssetViewSpriteRenderer_GameSpriteRendererLoaderInteractableOnReadyEvent__
		                         ,0);
		              if (DAT_ram_00a63bf9 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		                DAT_ram_00a63bf9 = '\x01';
		              }
		              iVar3 = *(int *)(iVar9 + 0x14);
		              while( true ) {
		                iVar7 = 0;
		                iVar8 = UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0);
		                uVar5 = System_Action_IAsyncLoadableContent__TypeInfo;
		                if ((iVar8 != 0) &&
		                   (iVar7 = func_ii_1082(iVar8,System_Action_IAsyncLoadableContent__TypeInfo),
		                   iVar7 == 0)) break;
		                iVar7 = func_ii_4329(iVar9 + 0x14,iVar7,iVar3);
		                bVar1 = iVar7 == iVar3;
		                iVar3 = iVar7;
		                if (bVar1) {
		                  return;
		                }
		              }
		              System_Activator__CreateInstance(iVar8,uVar5);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(iVar8,uVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(piVar10,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar10,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_AssetId ---
		void AssetContent_GameAssetViewSpriteRenderer__get_AssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63bdf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetContent_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63bdf = '\x01';
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x20),param2,0);
		  if (iVar2 == 0) {
		    AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId
		              (*(undefined4 *)(param1 + 0x10),0,param2);
		    UnityEngine_Transform__SetParent(*(undefined4 *)(param1 + 0x14),0,param2);
		    *(undefined4 *)(param1 + 0x24) = 0;
		    *(undefined4 *)(param1 + 0x20) = param2;
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		    if (iVar2 != 0) {
		      return;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x82369998;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82369998:
		    piVar6 = (int *)(param1 + 0x14);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                      (uVar4,*(undefined4 *)(param1 + 0x20),0);
		    *(int *)(param1 + 0x24) = iVar2;
		    if (*(int *)(iVar2 + 0x10) == 1) {
		      piVar6 = (int *)(param1 + 0x10);
		    }
		    else if (*(int *)(iVar2 + 0x10) != 2) goto code_r0x82369a71;
		    piVar6 = (int *)*piVar6;
		    if (piVar6 == (int *)0x0) {
		code_r0x82369a71:
		      uVar4 = unnamed_function_2232(&string___TypeInfo);
		      iVar2 = Mono_Security_ASN1Convert__ToOid(uVar4,6);
		      uVar4 = unnamed_function_2232(&StringLiteral_8420);
		      *(undefined4 *)(iVar2 + 0x10) = uVar4;
		      local_4 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x10);
		      uVar4 = func_ii_1081(DAT_ram_00a66958,&local_4);
		      uVar5 = unnamed_function_2232(&StringLiteral_19965);
		      uVar4 = func_ii_4419(uVar5,uVar4,0);
		      *(undefined4 *)(iVar2 + 0x14) = uVar4;
		      uVar4 = unnamed_function_2232(&StringLiteral_23245);
		      *(undefined4 *)(iVar2 + 0x18) = uVar4;
		      *(undefined4 *)(iVar2 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xc);
		      uVar4 = unnamed_function_2232(&StringLiteral_278);
		      *(undefined4 *)(iVar2 + 0x20) = uVar4;
		      *(undefined4 *)(iVar2 + 0x24) = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x14);
		      uVar4 = System_Single__ToString(iVar2,0);
		      uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      System_String__Concat(uVar5,uVar4,0);
		      uVar4 = unnamed_function_2232(&Method_AssetContent_GameAssetViewSpriteRenderer_set_AssetId__);
		      func_ii_1050(uVar5,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = 0;
		    uVar4 = *(undefined4 *)(param1 + 0x20);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_IGameAssetContent_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x82369a5a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_IGameAssetContent_TypeInfo,1);
		code_r0x82369a5a:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4,puVar3[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		undefined4 AssetContent_GameAssetViewSpriteRenderer__set_AssetId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63be0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetContent_TypeInfo);
		    DAT_ram_00a63be0 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param1 + 0x24) + 0x10);
		  if (iVar5 == 1) {
		    piVar6 = (int *)(param1 + 0x10);
		  }
		  else {
		    if (iVar5 != 2) goto code_r0x82369f67;
		    piVar6 = (int *)(param1 + 0x14);
		  }
		  piVar6 = (int *)*piVar6;
		  if (piVar6 != (int *)0x0) {
		    uVar1 = 0;
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_IGameAssetContent_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x82369f4d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_IGameAssetContent_TypeInfo,2);
		code_r0x82369f4d:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    return uVar3;
		  }
		code_r0x82369f67:
		  uVar3 = unnamed_function_2232(&string___TypeInfo);
		  iVar5 = Mono_Security_ASN1Convert__ToOid(uVar3,6);
		  uVar3 = unnamed_function_2232(&StringLiteral_8420);
		  *(undefined4 *)(iVar5 + 0x10) = uVar3;
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x10);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar4 = unnamed_function_2232(&StringLiteral_19965);
		  uVar3 = func_ii_4419(uVar4,uVar3,0);
		  *(undefined4 *)(iVar5 + 0x14) = uVar3;
		  uVar3 = unnamed_function_2232(&StringLiteral_23245);
		  *(undefined4 *)(iVar5 + 0x18) = uVar3;
		  *(undefined4 *)(iVar5 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xc);
		  uVar3 = unnamed_function_2232(&StringLiteral_278);
		  *(undefined4 *)(iVar5 + 0x20) = uVar3;
		  *(undefined4 *)(iVar5 + 0x24) = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x14);
		  uVar3 = System_Single__ToString(iVar5,0);
		  uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar4 = unnamed_function_1417(uVar4);
		  System_String__Concat(uVar4,uVar3,0);
		  uVar3 = unnamed_function_2232(&Method_AssetContent_GameAssetViewSpriteRenderer_get_AssetPath__);
		  func_ii_1050(uVar4,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_SortingLayerId ---
		int * AssetContent_GameAssetViewSpriteRenderer__set_SortingLayerId(int *param1)
		
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


		/* --- GHIDRA: get_Interactable ---
		void AssetContent_GameAssetViewSpriteRenderer__get_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *param1_01;
		  
		  *(char *)(param1 + 0x38) = (char)param2;
		  iVar4 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a63bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc0 = '\x01';
		  }
		  *(char *)(iVar4 + 0x1c) = (char)param2;
		  param1_01 = *(int **)(iVar4 + 0x3c);
		  if (param1_01 != (int *)0x0) {
		    uVar2 = 0;
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8))
		        {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xe8);
		          goto code_r0x8236a901;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Animations_IGameAnimation_TypeInfo,5);
		code_r0x8236a901:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param2,puVar3[1]);
		  }
		  iVar4 = *(int *)(param1 + 0x10);
		  cVar1 = *(char *)(param1 + 0x38);
		  *(char *)(iVar4 + 0x3c) = cVar1;
		  if (DAT_ram_00a63c04 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		    DAT_ram_00a63c04 = '\x01';
		  }
		  if (*(int *)(iVar4 + 0x38) == 0) {
		    param1_00 = func_ii_5677(iVar4,Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		    *(undefined4 *)(iVar4 + 0x38) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(iVar4 + 0x38);
		  }
		  UnityEngine_Object__op_Implicit(param1_00,(uint)(cVar1 != '\0'),0);
		  return;
		}
		*/


		/* --- GHIDRA: add_ResolveEvent ---
		void AssetContent_GameAssetViewSpriteRenderer__add_ResolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63be4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a63be4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ResolveEvent ---
		void AssetContent_GameAssetViewSpriteRenderer__remove_ResolveEvent
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int *param1_01;
		  int *param1_02;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  param1_02 = (int *)0x0;
		  if (DAT_ram_00a63be5 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Component_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_IBoundsProvider_TypeInfo);
		    DAT_ram_00a63be5 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x24) + 0x10);
		  if (iVar3 == 1) {
		    iVar3 = 0x10;
		  }
		  else {
		    if (iVar3 != 2) goto code_r0x8236ac97;
		    iVar3 = 0x14;
		  }
		  param1_01 = *(int **)(param2 + iVar3);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(UnityEngine_Component_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1_01 + 0xb8)) &&
		       (param1_02 = param1_01,
		       *(int *)(*(int *)(*param1_01 + 100) +
		                (uint)*(byte *)(UnityEngine_Component_TypeInfo + 0xb8) * 4 + -4) !=
		       UnityEngine_Component_TypeInfo)) {
		      param1_02 = (int *)0x0;
		    }
		    param1_00 = (int *)func_ii_1082(param1_01,UI_IBoundsProvider_TypeInfo);
		    if (param1_00 == (int *)0x0) {
		      param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (param1_02,0);
		      AssetContent_GameAssetViewSpriteRenderer___GrayscaleChanged_b__27_0
		                (&local_18,param2_00,param1_01);
		      param1[2] = local_8;
		      param1[1] = local_10;
		      *param1 = local_18;
		      return;
		    }
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (UI_IBoundsProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8236ac35;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,UI_IBoundsProvider_TypeInfo,0);
		code_r0x8236ac35:
		    (**(code **)((ulonglong)*puVar2 * 4))(&local_18,param1_00,puVar2[1]);
		    param1[2] = local_8;
		    param1[1] = local_10;
		    *param1 = local_18;
		    return;
		  }
		code_r0x8236ac97:
		  *param1 = 0;
		  param1[2] = 0;
		  param1[1] = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_Bounds ---
		void AssetContent_GameAssetViewSpriteRenderer__get_Bounds
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  float fVar4;
		  
		  fVar1 = *(float *)(param1 + 0x28);
		  if (DAT_ram_00a648f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Mathf_TypeInfo);
		    DAT_ram_00a648f3 = '\x01';
		  }
		  fVar2 = ABS(fVar1);
		  if (fVar2 <= ABS(param2)) {
		    fVar2 = ABS(param2);
		  }
		  fVar4 = **(float **)(UnityEngine_Mathf_TypeInfo + 0x5c) * 8.0;
		  fVar3 = fVar2 * 1e-06;
		  if (fVar2 * 1e-06 <= fVar4) {
		    fVar3 = fVar4;
		  }
		  if (fVar3 <= ABS(param2 - fVar1)) {
		    fVar1 = *(float *)(param1 + 0x28);
		    *(float *)(param1 + 0x28) = param2;
		    AssetContent_GameAssetViewSpriteRenderer__SetGrayscale(param1,fVar1,param2,param3,param1);
		  }
		  return;
		}
		*/

}
