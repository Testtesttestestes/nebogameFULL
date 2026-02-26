using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UI;
using UnityEngine;

namespace Core.Animations
{
	// Token: 0x0200127D RID: 4733
	[Token(Token = "0x200127D")]
	[RequireComponent(typeof(SkeletonGraphic))]
	public class GameSpineUiAnimation : MonoBehaviour, IGameAnimation, IBoundsProvider, ISkeletonGraphicProvider, IGrayscalable, IAlpha
	{
		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x00014700 File Offset: 0x00012900
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F5")]
		public bool Loop
		{
			[Token(Token = "0x6007077")]
			[Address(RVA = "0xBABB", Offset = "0xBABB", VA = "0xBABB", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007078")]
			[Address(RVA = "0xBABC", Offset = "0xBABC", VA = "0xBABC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016F6")]
		public SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x6007079")]
			[Address(RVA = "0x1CBB", Offset = "0x1CBB", VA = "0x1CBB", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600707A")]
		[Address(RVA = "0xBABD", Offset = "0xBABD", VA = "0xBABD")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Animations_GameSpineUiAnimation__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param1 + 0x14) != 0) {
		    Core_Materials_GrayscaleSpineUI__SetGrayscale(*(int *)(param1 + 0x14),0);
		  }
		  iVar2 = *(int *)(param1 + 0x18);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a898 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a5a898 = '\x01';
		    }
		    uVar3 = *(undefined4 *)(iVar2 + 0xc);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		    if (iVar1 != 0) {
		      uVar3 = *(undefined4 *)(iVar2 + 0xc);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(uVar3,0);
		      *(undefined4 *)(iVar2 + 0xc) = 0;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600707B RID: 28795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600707B")]
		[Address(RVA = "0xBABE", Offset = "0xBABE", VA = "0xBABE")]
		private void OnDestroy()
		{
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600707C RID: 28796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016F7")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x600707C")]
			[Address(RVA = "0xBABF", Offset = "0xBABF", VA = "0xBABF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000301 RID: 769
		// (add) Token: 0x0600707D RID: 28797 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600707E RID: 28798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000301")]
		public event Action<IGameAnimation> ClickEvent
		{
			[Token(Token = "0x600707D")]
			[Address(RVA = "0xBAC0", Offset = "0xBAC0", VA = "0xBAC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600707E")]
			[Address(RVA = "0xBAC1", Offset = "0xBAC1", VA = "0xBAC1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000302 RID: 770
		// (add) Token: 0x0600707F RID: 28799 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007080 RID: 28800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000302")]
		public event Action<IGameAnimation> CompleteEvent
		{
			[Token(Token = "0x600707F")]
			[Address(RVA = "0xBAC2", Offset = "0xBAC2", VA = "0xBAC2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007080")]
			[Address(RVA = "0xBAC3", Offset = "0xBAC3", VA = "0xBAC3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x00014718 File Offset: 0x00012918
		// (set) Token: 0x06007082 RID: 28802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F8")]
		public int SortingLayerId
		{
			[Token(Token = "0x6007081")]
			[Address(RVA = "0xBAC4", Offset = "0xBAC4", VA = "0xBAC4", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007082")]
			[Address(RVA = "0xBAC5", Offset = "0xBAC5", VA = "0xBAC5", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x00014730 File Offset: 0x00012930
		// (set) Token: 0x06007084 RID: 28804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F9")]
		public bool Interactable
		{
			[Token(Token = "0x6007083")]
			[Address(RVA = "0xBAC6", Offset = "0xBAC6", VA = "0xBAC6", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007084")]
			[Address(RVA = "0xBAC7", Offset = "0xBAC7", VA = "0xBAC7", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x00014748 File Offset: 0x00012948
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016FA")]
		public int SortingOrder
		{
			[Token(Token = "0x6007085")]
			[Address(RVA = "0xBAC8", Offset = "0xBAC8", VA = "0xBAC8", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007086")]
			[Address(RVA = "0xBAC9", Offset = "0xBAC9", VA = "0xBAC9", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007087")]
		[Address(RVA = "0x1CBE", Offset = "0x1CBE", VA = "0x1CBE", Slot = "16")]
		public void Play(bool loop)
		{
		/* --- GHIDRA: Play ---
		void Core_Animations_GameSpineUiAnimation__Play(int param1,float param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0xc) = 0xbf800000;
		  *(float *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Play ---
		void Core_Animations_GameSpineUiAnimation__Play(int param1,float param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0xc) = 0xbf800000;
		  *(float *)(param1 + 8) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06007088 RID: 28808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007088")]
		[Address(RVA = "0xBACA", Offset = "0xBACA", VA = "0xBACA")]
		private string GetFirstAnimationName()
		{
		/* --- GHIDRA: GetFirstAnimationName ---
		void Core_Animations_GameSpineUiAnimation__GetFirstAnimationName
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a8bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Animations_GameSpineUiAnimation_AnimationStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a5a8bc = '\x01';
		  }
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    *(int *)(param1 + 0x10) = iVar1;
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x10);
		  }
		  param1_01 = *(undefined4 *)(iVar1 + 0xdc);
		  param1_00 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (param1_00,param1,Method_Core_Animations_GameSpineUiAnimation_AnimationStateOnComplete__
		             ,0);
		  Spine_AnimationState__add_Complete(param1_01,param1_00,0);
		  iVar1 = *(int *)(param1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007089")]
		[Address(RVA = "0xBACB", Offset = "0xBACB", VA = "0xBACB")]
		private void AnimationStateOnComplete(TrackEntry trackEntry)
		{
		/* --- GHIDRA: AnimationStateOnComplete ---
		void Core_Animations_GameSpineUiAnimation__AnimationStateOnComplete(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    *(undefined4 *)(param1 + 0x10) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		  }
		  Spine_Unity_SkeletonGraphic__TrimRenderers(param1_00,1,0);
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    *(int *)(param1 + 0x10) = iVar1;
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x10);
		  }
		  *(undefined4 *)(iVar1 + 0x94) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600708A RID: 28810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708A")]
		[Address(RVA = "0xBACC", Offset = "0xBACC", VA = "0xBACC", Slot = "17")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Animations_GameSpineUiAnimation__Stop(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    *(int *)(param1 + 0x10) = iVar1;
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x10);
		  }
		  *(undefined4 *)(iVar1 + 0x94) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708B")]
		[Address(RVA = "0xBACD", Offset = "0xBACD", VA = "0xBACD", Slot = "19")]
		public void Pause()
		{
		/* --- GHIDRA: Pause ---
		void Core_Animations_GameSpineUiAnimation__Pause(int param1,float param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a8be == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Materials_GrayscaleSpineUI_TypeInfo);
		    DAT_ram_00a5a8be = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(Core_Materials_GrayscaleSpineUI_TypeInfo);
		    UnityEngine_Purchasing_Default_WinProductDescription__set_price(param1_00,param1,0);
		    *(int *)(param1 + 0x14) = param1_00;
		  }
		  Core_Materials_GrayscaleSpineUI___ctor(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600708C RID: 28812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708C")]
		[Address(RVA = "0x1CB7", Offset = "0x1CB7", VA = "0x1CB7", Slot = "18")]
		public void Play(string state, bool loop)
		{
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708D")]
		[Address(RVA = "0xBACE", Offset = "0xBACE", VA = "0xBACE", Slot = "22")]
		public void SetGrayscale(float value)
		{
		/* --- GHIDRA: SetGrayscale ---
		void Core_Animations_GameSpineUiAnimation__SetGrayscale(int param1,float param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a8bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_AlphaSpineUI_TypeInfo);
		    DAT_ram_00a5a8bf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(Core_Animations_AlphaSpineUI_TypeInfo);
		    *(int *)(param1_00 + 0x10) = param1;
		    *(int *)(param1 + 0x18) = param1_00;
		  }
		  Core_Animations_AlphaSpineUI___ctor(param1_00,param2,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x0600708E RID: 28814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708E")]
		[Address(RVA = "0xBACF", Offset = "0xBACF", VA = "0xBACF", Slot = "23")]
		public void SetAlpha(float value)
		{
		/* --- GHIDRA: SetAlpha ---
		void Core_Animations_GameSpineUiAnimation__SetAlpha(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param2 + 0x10) == 0) {
		    uVar1 = func_ii_5677(param2,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    *(undefined4 *)(param2 + 0x10) = uVar1;
		  }
		  else {
		    uVar1 = *(undefined4 *)(param2 + 0x10);
		  }
		  uVar1 = Spine_Unity_SkeletonGraphic__get_MeshGenerator(uVar1,0);
		  UnityEngine_Mesh__set_subMeshCount(&local_18,uVar1,0);
		  param1[2] = local_8;
		  param1[1] = local_10;
		  *param1 = local_18;
		  return;
		}
		*/

		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x170016FB")]
		public Bounds Bounds
		{
			[Token(Token = "0x600708F")]
			[Address(RVA = "0xBAD0", Offset = "0xBAD0", VA = "0xBAD0", Slot = "20")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007090")]
		[Address(RVA = "0xBAD1", Offset = "0xBAD1", VA = "0xBAD1")]
		public GameSpineUiAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Animations_GameSpineUiAnimation___ctor(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a8c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGameAnimation___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a5a8c0 = '\x01';
		  }
		  param1_00 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGameAnimation___
		                                 );
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		          goto code_r0x812869c7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x812869c7:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,1,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04003AAC RID: 15020
		[Token(Token = "0x4003AAC")]
		[FieldOffset(Offset = "0x10")]
		private SkeletonGraphic _skeletonGraphic;

		// Token: 0x04003AAD RID: 15021
		[Token(Token = "0x4003AAD")]
		[FieldOffset(Offset = "0x14")]
		private GrayscaleSpineUI _grayscale;

		// Token: 0x04003AAE RID: 15022
		[Token(Token = "0x4003AAE")]
		[FieldOffset(Offset = "0x18")]
		private AlphaSpineUI _alpha;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Loop ---
		void Core_Animations_GameSpineUiAnimation__set_Loop(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5a8b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    DAT_ram_00a5a8b6 = '\x01';
		  }
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    piVar1 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___
		                                );
		    *(int **)(param1 + 0x10) = piVar1;
		  }
		  else {
		    piVar1 = *(int **)(param1 + 0x10);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1c8) * 4))
		            (piVar1,*(undefined4 *)
		                     (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 4),
		             *(undefined4 *)(*piVar1 + 0x1cc));
		  Core_Animations_GameSpineUiAnimation__AnimationStateOnComplete(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_SkeletonGraphic ---
		undefined4
		Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic
		          (undefined4 param1,float param2,float param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a548f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_Color__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_Color__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetTarget_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_DG_Tweening_DOTweenModuleUI___c__DisplayClass2_0__DOFade_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_DG_Tweening_DOTweenModuleUI___c__DisplayClass2_0__DOFade_b__1__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTweenModuleUI___c__DisplayClass2_0_TypeInfo);
		    DAT_ram_00a548f5 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(DG_Tweening_DOTweenModuleUI___c__DisplayClass2_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param1;
		  uVar1 = unnamed_function_1417(DG_Tweening_Core_DOGetter_Color__TypeInfo);
		  UnityEngine_UIElements_CustomStyleProperty___Il2CppFullySharedGenericType___set_name
		            (uVar1,param2_00,Method_DG_Tweening_DOTweenModuleUI___c__DisplayClass2_0__DOFade_b__0__,
		             0);
		  param1_00 = unnamed_function_1417(DG_Tweening_Core_DOSetter_Color__TypeInfo);
		  DG_Tweening_Core_DOGetter___Il2CppFullySharedGenericType___Invoke
		            (param1_00,param2_00,
		             Method_DG_Tweening_DOTweenModuleUI___c__DisplayClass2_0__DOFade_b__1__,0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar1 = DG_Tweening_DOTween__ToAxis(uVar1,param1_00,param2,param3,0);
		  DG_Tweening_TweenSettingsExtensions__SetSpeedBased_object_
		            (uVar1,*(undefined4 *)(param2_00 + 8),
		             Method_DG_Tweening_TweenSettingsExtensions_SetTarget_TweenerCore_Color__Color__ColorOptions____
		            );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_MonoBehaviour ---
		void Core_Animations_GameSpineUiAnimation__get_MonoBehaviour
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8b7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGameAnimation__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGameAnimation__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickEvent ---
		void Core_Animations_GameSpineUiAnimation__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8b8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGameAnimation__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGameAnimation__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Core_Animations_GameSpineUiAnimation__remove_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8b9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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


		/* --- GHIDRA: add_CompleteEvent ---
		void Core_Animations_GameSpineUiAnimation__add_CompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    DAT_ram_00a5a8ba = '\x01';
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


		/* --- GHIDRA: set_SortingLayerId ---
		undefined4 Core_Animations_GameSpineUiAnimation__set_SortingLayerId(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    piVar1 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___
		                                );
		    *(int **)(param1 + 0x10) = piVar1;
		  }
		  else {
		    piVar1 = *(int **)(param1 + 0x10);
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x180) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x184));
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_Interactable ---
		void Core_Animations_GameSpineUiAnimation__get_Interactable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    piVar1 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___
		                                );
		    *(int **)(param1 + 0x10) = piVar1;
		  }
		  else {
		    piVar1 = *(int **)(param1 + 0x10);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x188) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x18c));
		  return;
		}
		*/


		/* --- GHIDRA: set_SortingOrder ---
		undefined4 Core_Animations_GameSpineUiAnimation__set_SortingOrder(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a8bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Animation___);
		    DAT_ram_00a5a8bb = '\x01';
		  }
		  if (DAT_ram_00a5a8b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    DAT_ram_00a5a8b5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SkeletonGraphic___);
		    *(undefined4 *)(param1 + 0x10) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		  }
		  iVar1 = Spine_Unity_SkeletonGraphic__set_Skeleton(param1_00,0);
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(iVar1 + 0x20),Method_System_Linq_Enumerable_First_Animation___)
		  ;
		  return *(undefined4 *)(iVar1 + 8);
		}
		*/

}
