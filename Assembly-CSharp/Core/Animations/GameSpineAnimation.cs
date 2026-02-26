using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Animations
{
	// Token: 0x0200127B RID: 4731
	[Token(Token = "0x200127B")]
	[RequireComponent(typeof(SkeletonAnimation))]
	public class GameSpineAnimation : MonoBehaviour, IGameAnimation, IPointerClickHandler, IEventSystemHandler, IGrayscalable, IAlpha
	{
		// Token: 0x140002FF RID: 767
		// (add) Token: 0x0600705A RID: 28762 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600705B RID: 28763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FF")]
		public event Action<IGameAnimation> ClickEvent
		{
			[Token(Token = "0x600705A")]
			[Address(RVA = "0xBA9F", Offset = "0xBA9F", VA = "0xBA9F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600705B")]
			[Address(RVA = "0xBAA0", Offset = "0xBAA0", VA = "0xBAA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016EE")]
		public MeshRenderer MeshRenderer
		{
			[Token(Token = "0x600705C")]
			[Address(RVA = "0xBAA1", Offset = "0xBAA1", VA = "0xBAA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016EF")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x600705D")]
			[Address(RVA = "0xBAA2", Offset = "0xBAA2", VA = "0xBAA2", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x0600705E RID: 28766 RVA: 0x00014670 File Offset: 0x00012870
		// (set) Token: 0x0600705F RID: 28767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F0")]
		public bool IsInit
		{
			[Token(Token = "0x600705E")]
			[Address(RVA = "0xBAA3", Offset = "0xBAA3", VA = "0xBAA3")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600705F")]
			[Address(RVA = "0xBAA4", Offset = "0xBAA4", VA = "0xBAA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x00014688 File Offset: 0x00012888
		// (set) Token: 0x06007061 RID: 28769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F1")]
		public int SortingLayerId
		{
			[Token(Token = "0x6007060")]
			[Address(RVA = "0xBAA5", Offset = "0xBAA5", VA = "0xBAA5", Slot = "11")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007061")]
			[Address(RVA = "0xBAA6", Offset = "0xBAA6", VA = "0xBAA6", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x14000300 RID: 768
		// (add) Token: 0x06007062 RID: 28770 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007063 RID: 28771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000300")]
		public event Action<IGameAnimation> CompleteEvent
		{
			[Token(Token = "0x6007062")]
			[Address(RVA = "0xBAA7", Offset = "0xBAA7", VA = "0xBAA7", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007063")]
			[Address(RVA = "0xBAA8", Offset = "0xBAA8", VA = "0xBAA8", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06007064 RID: 28772 RVA: 0x000146A0 File Offset: 0x000128A0
		// (set) Token: 0x06007065 RID: 28773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F2")]
		public bool Interactable
		{
			[Token(Token = "0x6007064")]
			[Address(RVA = "0xBAA9", Offset = "0xBAA9", VA = "0xBAA9", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007065")]
			[Address(RVA = "0xBAAA", Offset = "0xBAAA", VA = "0xBAAA", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06007066 RID: 28774 RVA: 0x000146B8 File Offset: 0x000128B8
		// (set) Token: 0x06007067 RID: 28775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F3")]
		public int SortingOrder
		{
			[Token(Token = "0x6007066")]
			[Address(RVA = "0xBAAB", Offset = "0xBAAB", VA = "0xBAAB", Slot = "13")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007067")]
			[Address(RVA = "0xBAAC", Offset = "0xBAAC", VA = "0xBAAC", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007068")]
		[Address(RVA = "0xBAAD", Offset = "0xBAAD", VA = "0xBAAD")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Animations_GameSpineAnimation__Awake(int param1,undefined4 param2)
		
		{
		  undefined1 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a8b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Materials_AlphaSpine_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonAnimation___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_MeshRenderer___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Materials_GrayscaleSpine_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkeletonDataModifierAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SkeletonDataModifierAsset__set_Item__);
		    DAT_ram_00a5a8b0 = '\x01';
		  }
		  if (*(char *)(param1 + 0x30) == '\0') {
		    uVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonAnimation___);
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar2,0);
		    uVar2 = func_ii_6601(uVar2,Method_UnityEngine_GameObject_GetComponent_MeshRenderer___);
		    *(undefined4 *)(param1 + 0x14) = uVar2;
		    uVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		    *(undefined4 *)(param1 + 0x18) = uVar2;
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    uVar2 = unnamed_function_1417(Core_Materials_GrayscaleSpine_TypeInfo);
		    UnityEngine_Purchasing_Default_WinProductDescription__set_platformSpecificID(uVar2,uVar3,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar2;
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    uVar2 = unnamed_function_1417(Core_Materials_AlphaSpine_TypeInfo);
		    UnityEngine_Purchasing_Default_WinProductDescription__set_platformSpecificID(uVar2,uVar3,0);
		    *(undefined4 *)(param1 + 0x20) = uVar2;
		    iVar4 = *(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x10) + 0x18);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      System_Collections_Generic_List_UsageHint___get_Item
		                (iVar4,0,**(undefined4 **)
		                           (Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c),
		                 Method_System_Collections_Generic_List_SkeletonDataModifierAsset__set_Item__);
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x28);
		    if (DAT_ram_00a5a8ab == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a5a8ab = '\x01';
		    }
		    *(undefined4 *)(param1 + 0x28) = uVar2;
		    uVar2 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar4 != 0) {
		      func_ii_7677(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x28),0);
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x3c);
		    if (DAT_ram_00a5a8af == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a5a8af = '\x01';
		    }
		    *(undefined4 *)(param1 + 0x3c) = uVar2;
		    uVar2 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar4 != 0) {
		      AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		                (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x3c),0);
		    }
		    uVar1 = *(undefined1 *)(param1 + 0x38);
		    if (DAT_ram_00a5a8ae == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a5a8ae = '\x01';
		    }
		    *(undefined1 *)(param1 + 0x38) = uVar1;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar4 != 0) {
		      UnityEngine_Object__op_Implicit
		                (*(undefined4 *)(param1 + 0x18),(uint)*(byte *)(param1 + 0x38),0);
		    }
		    *(undefined1 *)(param1 + 0x30) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007069 RID: 28777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007069")]
		[Address(RVA = "0xBAAE", Offset = "0xBAAE", VA = "0xBAAE")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Animations_GameSpineAnimation__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x30) != '\0') {
		    if (DAT_ram_00a5a8b2 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Animation___);
		      DAT_ram_00a5a8b2 = '\x01';
		    }
		    iVar1 = Spine_Unity_SkeletonDataAsset__GetAnimationStateData
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0,0);
		    iVar1 = System_Linq_Enumerable__Count_object_
		                      (*(undefined4 *)(iVar1 + 0x20),
		                       Method_System_Linq_Enumerable_First_Animation___);
		    Core_Animations_GameSpineAnimation__set_Loop(param1,*(undefined4 *)(iVar1 + 8),param2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600706A RID: 28778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706A")]
		[Address(RVA = "0xBAAF", Offset = "0xBAAF", VA = "0xBAAF", Slot = "16")]
		public void Play(bool loop)
		{
		/* --- GHIDRA: Play ---
		float Core_Animations_GameSpineAnimation__Play(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a8b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Animation___);
		    DAT_ram_00a5a8b1 = '\x01';
		  }
		  iVar1 = Spine_Unity_SkeletonDataAsset__GetAnimationStateData
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0,0);
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(iVar1 + 0x20),Method_System_Linq_Enumerable_First_Animation___)
		  ;
		  return *(float *)(iVar1 + 0x14);
		}
		*/

		/* --- GHIDRA: Play ---
		float Core_Animations_GameSpineAnimation__Play(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a8b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Animation___);
		    DAT_ram_00a5a8b1 = '\x01';
		  }
		  iVar1 = Spine_Unity_SkeletonDataAsset__GetAnimationStateData
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0,0);
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(iVar1 + 0x20),Method_System_Linq_Enumerable_First_Animation___)
		  ;
		  return *(float *)(iVar1 + 0x14);
		}
		*/

		}

		// Token: 0x0600706B RID: 28779 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x600706B")]
		[Address(RVA = "0xBAB0", Offset = "0xBAB0", VA = "0xBAB0")]
		public float GetFirstAnimationDuration()
		{
		/* --- GHIDRA: GetFirstAnimationDuration ---
		undefined4
		Core_Animations_GameSpineAnimation__GetFirstAnimationDuration(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a8b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Animation___);
		    DAT_ram_00a5a8b2 = '\x01';
		  }
		  iVar1 = Spine_Unity_SkeletonDataAsset__GetAnimationStateData
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0,0);
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(iVar1 + 0x20),Method_System_Linq_Enumerable_First_Animation___)
		  ;
		  return *(undefined4 *)(iVar1 + 8);
		}
		*/

			return 0f;
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600706C")]
		[Address(RVA = "0xBAB1", Offset = "0xBAB1", VA = "0xBAB1")]
		private string GetFirstAnimationName()
		{
		/* --- GHIDRA: GetFirstAnimationName ---
		void Core_Animations_GameSpineAnimation__GetFirstAnimationName
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5a8b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Animations_GameSpineAnimation_AnimationStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a5a8b3 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x80);
		  param1_00 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (param1_00,param1,Method_Core_Animations_GameSpineAnimation_AnimationStateOnComplete__,0
		            );
		  Spine_AnimationState__add_Complete(param1_01,param1_00,0);
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706D")]
		[Address(RVA = "0xBAB2", Offset = "0xBAB2", VA = "0xBAB2")]
		private void AnimationStateOnComplete(TrackEntry trackEntry)
		{
		/* --- GHIDRA: AnimationStateOnComplete ---
		void Core_Animations_GameSpineAnimation__AnimationStateOnComplete(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0xa0) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706E")]
		[Address(RVA = "0x1C32", Offset = "0x1C32", VA = "0x1C32", Slot = "17")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Animations_GameSpineAnimation__Stop(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6241c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_MarshalledUnityObject_MarshalNotNull_Renderer___);
		    DAT_ram_00a6241c = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 == 0) {
		    System_Collections_Generic_ArraySortHelper_AppBuildInfo_Element___InternalBinarySearch(param1,0)
		    ;
		  }
		  if (DAT_ram_00a62464 == 0) {
		    DAT_ram_00a62464 = func_ii_2140(s_UnityEngine_Renderer__set_enable_ram_00067f53);
		  }
		  (**(code **)((ulonglong)DAT_ram_00a62464 * 4))(iVar1,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600706F RID: 28783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706F")]
		[Address(RVA = "0xBAB3", Offset = "0xBAB3", VA = "0xBAB3", Slot = "19")]
		public void Pause()
		{
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06007070 RID: 28784 RVA: 0x000146E8 File Offset: 0x000128E8
		// (set) Token: 0x06007071 RID: 28785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F4")]
		public bool Loop
		{
			[Token(Token = "0x6007070")]
			[Address(RVA = "0xBAB4", Offset = "0xBAB4", VA = "0xBAB4", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007071")]
			[Address(RVA = "0xBAB5", Offset = "0xBAB5", VA = "0xBAB5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007072")]
		[Address(RVA = "0xBAB6", Offset = "0xBAB6", VA = "0xBAB6", Slot = "18")]
		public void Play(string state, bool loop)
		{
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007073")]
		[Address(RVA = "0xBAB7", Offset = "0xBAB7", VA = "0xBAB7", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Core_Animations_GameSpineAnimation__OnPointerClick(int param1,float param2,undefined4 param3)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    Core_Materials_GrayscaleSpine__get_MaterialPropertyBlock
		              (*(int *)(param1 + 0x1c),param2,param1 + 0x2c,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007074 RID: 28788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007074")]
		[Address(RVA = "0xBAB8", Offset = "0xBAB8", VA = "0xBAB8", Slot = "21")]
		public void SetGrayscale(float value)
		{
		/* --- GHIDRA: SetGrayscale ---
		void Core_Animations_GameSpineAnimation__SetGrayscale(int param1,float param2,undefined4 param3)
		
		{
		  if (*(int *)(param1 + 0x20) != 0) {
		    Core_Materials_AlphaSpine__get_MaterialPropertyBlock
		              (*(int *)(param1 + 0x20),param2,param1 + 0x2c,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007075 RID: 28789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007075")]
		[Address(RVA = "0xBAB9", Offset = "0xBAB9", VA = "0xBAB9", Slot = "22")]
		public void SetAlpha(float value)
		{
		/* --- GHIDRA: SetAlpha ---
		void Core_Animations_GameSpineAnimation__SetAlpha(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x38) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06007076 RID: 28790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007076")]
		[Address(RVA = "0xBABA", Offset = "0xBABA", VA = "0xBABA")]
		public GameSpineAnimation()
		{
		}

		// Token: 0x04003A98 RID: 15000
		[Token(Token = "0x4003A98")]
		[FieldOffset(Offset = "0x10")]
		private SkeletonAnimation _skeletonAnimation;

		// Token: 0x04003A99 RID: 15001
		[Token(Token = "0x4003A99")]
		[FieldOffset(Offset = "0x14")]
		private MeshRenderer _meshRenderer;

		// Token: 0x04003A9A RID: 15002
		[Token(Token = "0x4003A9A")]
		[FieldOffset(Offset = "0x18")]
		private PolygonCollider2D _polygonCollider2D;

		// Token: 0x04003A9B RID: 15003
		[Token(Token = "0x4003A9B")]
		[FieldOffset(Offset = "0x1C")]
		private GrayscaleSpine _grayscale;

		// Token: 0x04003A9C RID: 15004
		[Token(Token = "0x4003A9C")]
		[FieldOffset(Offset = "0x20")]
		private AlphaSpine _alpha;

		// Token: 0x04003A9E RID: 15006
		[Token(Token = "0x4003A9E")]
		[FieldOffset(Offset = "0x28")]
		private int _sortingLayerId;

		// Token: 0x04003A9F RID: 15007
		[Token(Token = "0x4003A9F")]
		[FieldOffset(Offset = "0x2C")]
		private MaterialType _materialType;

		// Token: 0x04003AA2 RID: 15010
		[Token(Token = "0x4003AA2")]
		[FieldOffset(Offset = "0x38")]
		private bool _interactable;

		// Token: 0x04003AA3 RID: 15011
		[Token(Token = "0x4003AA3")]
		[FieldOffset(Offset = "0x3C")]
		private int _sortingOrder;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Core_Animations_GameSpineAnimation__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGameAnimation__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGameAnimation__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: get_SortingLayerId ---
		void Core_Animations_GameSpineAnimation__get_SortingLayerId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8ab == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a8ab = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    func_ii_7677(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x28),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_SortingLayerId ---
		void Core_Animations_GameSpineAnimation__set_SortingLayerId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8ac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGameAnimation__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGameAnimation__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: add_CompleteEvent ---
		void Core_Animations_GameSpineAnimation__add_CompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8ad = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGameAnimation__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGameAnimation__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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
		void Core_Animations_GameSpineAnimation__get_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8ae == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a8ae = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x38) = (undefined1)param2;
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x18),(uint)*(byte *)(param1 + 0x38),0)
		    ;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_SortingOrder ---
		void Core_Animations_GameSpineAnimation__get_SortingOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8af == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a8af = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		              (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x3c),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_SortingOrder ---
		void Core_Animations_GameSpineAnimation__set_SortingOrder(undefined4 param1,undefined4 param2)
		
		{
		  Core_Animations_GameSpineAnimation__Awake(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Loop ---
		void Core_Animations_GameSpineAnimation__set_Loop
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a8b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Animations_GameSpineAnimation_AnimationStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a5a8b4 = '\x01';
		  }
		  *(char *)(param1 + 0x40) = (char)param3;
		  iVar2 = *(int *)(param1 + 0x10);
		  *(undefined4 *)(iVar2 + 0xa0) = 0x3f800000;
		  uVar3 = *(undefined4 *)(iVar2 + 0x80);
		  uVar1 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar1,param1,Method_Core_Animations_GameSpineAnimation_AnimationStateOnComplete__,0);
		  Spine_AnimationState__add_Complete(uVar3,uVar1,0);
		  if (param3 == 0) {
		    uVar3 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x80);
		    uVar1 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    Spine_AnimationState____ctor_b__45_0
		              (uVar1,param1,Method_Core_Animations_GameSpineAnimation_AnimationStateOnComplete__,0);
		    Spine_AnimationState__remove_Dispose(uVar3,uVar1,0);
		  }
		  Spine_AnimationState__SetCurrent
		            (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x80),0,param2,param3,0);
		  Spine_Unity_SkeletonAnimation__Update(*(undefined4 *)(param1 + 0x10),0.0,0);
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x114));
		  return;
		}
		*/

}
