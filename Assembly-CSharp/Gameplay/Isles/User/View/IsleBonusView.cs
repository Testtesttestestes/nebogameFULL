using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D17 RID: 3351
	[Token(Token = "0x2000D17")]
	public class IsleBonusView : MonoBehaviour, IBoundsProvider
	{
		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001089")]
		public GameSpriteRendererLoaderInteractable SpriteLoader
		{
			[Token(Token = "0x60051C7")]
			[Address(RVA = "0x9FA1", Offset = "0x9FA1", VA = "0x9FA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x0000EE38 File Offset: 0x0000D038
		// (set) Token: 0x060051C9 RID: 20937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108A")]
		public uint BonusId
		{
			[Token(Token = "0x60051C8")]
			[Address(RVA = "0x9FA2", Offset = "0x9FA2", VA = "0x9FA2")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60051C9")]
			[Address(RVA = "0x9FA3", Offset = "0x9FA3", VA = "0x9FA3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x0000EE50 File Offset: 0x0000D050
		// (set) Token: 0x060051CB RID: 20939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108B")]
		public uint PositionId
		{
			[Token(Token = "0x60051CA")]
			[Address(RVA = "0x9FA4", Offset = "0x9FA4", VA = "0x9FA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60051CB")]
			[Address(RVA = "0x9FA5", Offset = "0x9FA5", VA = "0x9FA5")]
			set
			{
			}
		}

		// Token: 0x1700108C RID: 4236
		// (set) Token: 0x060051CC RID: 20940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108C")]
		public Vector2 Position
		{
			[Token(Token = "0x60051CC")]
			[Address(RVA = "0x9FA6", Offset = "0x9FA6", VA = "0x9FA6")]
			set
			{
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700108D")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x60051CD")]
			[Address(RVA = "0x9FA7", Offset = "0x9FA7", VA = "0x9FA7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x9FA8", Offset = "0x9FA8", VA = "0x9FA8")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Isles_User_View_IsleBonusView__OnDisable(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a58d44 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_User_View_IsleBonusView_HandleReadyEvent__);
		    DAT_ram_00a58d44 = '\x01';
		  }
		  param2_00 = *(int *)(param1 + 0x14);
		  if (*(char *)(param2_00 + 0x30) != '\0') {
		    Gameplay_Isles_User_View_IsleBonusView__OnEnable(param1,param2_00,param1);
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Isles_User_View_IsleBonusView_HandleReadyEvent__,0);
		  AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0___LoadAsset_b__1
		            (param2_00,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x9FA9", Offset = "0x9FA9", VA = "0x9FA9")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Isles_User_View_IsleBonusView__OnEnable(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58d45 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IAsyncLoadableContent_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_User_View_IsleBonusView_HandleReadyEvent__);
		    DAT_ram_00a58d45 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Isles_User_View_IsleBonusView_HandleReadyEvent__,0);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IAsyncLoadableContent_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80fa0fe9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IAsyncLoadableContent_TypeInfo,2);
		code_r0x80fa0fe9:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  if (DAT_ram_00a58d42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58d42 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x20);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    *(int **)(param1 + 0x20) = piVar4;
		  }
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80fa10a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		code_r0x80fa10a3:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (DAT_ram_00a58d42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58d42 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x20);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    *(int **)(param1 + 0x20) = piVar4;
		  }
		  uVar1 = 0;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		  *(ulonglong *)(iVar5 + 0x10) = (ulonglong)*(uint *)(param1 + 0x18);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x80fa117a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5);
		code_r0x80fa117a:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,iVar5,puVar3[1]);
		  UnityEngine_Object__op_Implicit(uVar2,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D0")]
		[Address(RVA = "0x9FAA", Offset = "0x9FAA", VA = "0x9FAA")]
		private void HandleReadyEvent(IAsyncLoadableContent content)
		{
		/* --- GHIDRA: HandleReadyEvent ---
		void Gameplay_Isles_User_View_IsleBonusView__HandleReadyEvent
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  AssetContent_Loaders_GameSpriteRendererLoaderInteractable__OnPointerClick
		            (&local_18,*(undefined4 *)(param2 + 0x14),0);
		  param1[2] = local_8;
		  param1[1] = local_10;
		  *param1 = local_18;
		  return;
		}
		*/

		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x1700108E")]
		public Bounds Bounds
		{
			[Token(Token = "0x60051D1")]
			[Address(RVA = "0x9FAB", Offset = "0x9FAB", VA = "0x9FAB", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x9FAC", Offset = "0x9FAC", VA = "0x9FAC")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Isles_User_View_IsleBonusView__Awake(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d47 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleBonusView__TypeInfo);
		    DAT_ram_00a58d47 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IsleBonusView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleBonusView__TypeInfo), iVar2 == 0)) break;
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

		}

		// Token: 0x140001F3 RID: 499
		// (add) Token: 0x060051D3 RID: 20947 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051D4 RID: 20948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F3")]
		public event Action<IsleBonusView> ClickEvent
		{
			[Token(Token = "0x60051D3")]
			[Address(RVA = "0x9FAD", Offset = "0x9FAD", VA = "0x9FAD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051D4")]
			[Address(RVA = "0x9FAE", Offset = "0x9FAE", VA = "0x9FAE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x9FAF", Offset = "0x9FAF", VA = "0x9FAF")]
		private void SpriteLoaderOnClickEvent()
		{
		/* --- GHIDRA: SpriteLoaderOnClickEvent ---
		void Gameplay_Isles_User_View_IsleBonusView__SpriteLoaderOnClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d49 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleBonusView_SpriteLoaderOnClickEvent__);
		    DAT_ram_00a58d49 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Isles_User_View_IsleBonusView_SpriteLoaderOnClickEvent__,0);
		  AssetContent_Loaders_GameSpriteRendererLoaderInteractable__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x9FB0", Offset = "0x9FB0", VA = "0x9FB0")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Isles_User_View_IsleBonusView__OnDestroy(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 0x42000000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x9FB1", Offset = "0x9FB1", VA = "0x9FB1")]
		public IsleBonusView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_View_IsleBonusView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d4a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58d4a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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

		}

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _resourceOffset;

		// Token: 0x04002C79 RID: 11385
		[Token(Token = "0x4002C79")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameSpriteRendererLoaderInteractable _spriteLoader;

		// Token: 0x04002C7B RID: 11387
		[Token(Token = "0x4002C7B")]
		[FieldOffset(Offset = "0x1C")]
		private uint _positionId;

		// Token: 0x04002C7C RID: 11388
		[Token(Token = "0x4002C7C")]
		[FieldOffset(Offset = "0x20")]
		private IGuideTarget _guideTarget;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PositionId ---
		void Gameplay_Isles_User_View_IsleBonusView__get_PositionId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58d41 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3948);
		    DAT_ram_00a58d41 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(param1 + 0x1c,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3948,uVar1,0);
		  UnityEngine_Texture2D___ctor(param1_00,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_PositionId ---
		void Gameplay_Isles_User_View_IsleBonusView__set_PositionId
		               (int param1,float *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  undefined8 local_18;
		  float local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  fVar1 = *(float *)(param1 + 0x10);
		  fVar2 = param2[1];
		  fVar3 = *param2;
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  local_10 = fVar1 * 0.0 + 0.0;
		  local_c = (float4)(fVar3 + fVar1);
		  local_8 = (float4)(-fVar1 - fVar2);
		  local_18 = CONCAT44(local_8,local_c);
		  local_4 = (float4)local_10;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(param1_00,&local_18,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Position ---
		int Gameplay_Isles_User_View_IsleBonusView__set_Position(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58d42 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    *(int *)(param1 + 0x20) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_GuideTarget ---
		void Gameplay_Isles_User_View_IsleBonusView__get_GuideTarget(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a58d43 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_User_View_IsleBonusView_HandleReadyEvent__);
		    DAT_ram_00a58d43 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Isles_User_View_IsleBonusView_HandleReadyEvent__,0);
		  AssetContent_Loaders_GameSpriteRendererLoader__add_ReadyEvent(param1_00,uVar2,0);
		  if (DAT_ram_00a58d42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58d42 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x20);
		  if (param1_01 == (int *)0x0) {
		    param1_01 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___
		                                   );
		    *(int **)(param1 + 0x20) = param1_01;
		  }
		  uVar1 = 0;
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80fa0e98;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4
		                               );
		code_r0x80fa0e98:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  UnityEngine_Object__op_Implicit(uVar2,0,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Bounds ---
		void Gameplay_Isles_User_View_IsleBonusView__get_Bounds(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleBonusView_SpriteLoaderOnClickEvent__);
		    DAT_ram_00a58d46 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Isles_User_View_IsleBonusView_SpriteLoaderOnClickEvent__,0);
		  AssetContent_Loaders_GameSpriteRendererLoader___ctor(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Isles_User_View_IsleBonusView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d48 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleBonusView__TypeInfo);
		    DAT_ram_00a58d48 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IsleBonusView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleBonusView__TypeInfo), iVar2 == 0)) break;
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

}
