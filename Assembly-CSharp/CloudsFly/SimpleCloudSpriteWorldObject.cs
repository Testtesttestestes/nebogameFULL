using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001304 RID: 4868
	[Token(Token = "0x2001304")]
	public class SimpleCloudSpriteWorldObject : WorldObject<SimpleSpriteCloudWorldObjectArgs>
	{
		// Token: 0x060073D3 RID: 29651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0xBDB6", Offset = "0xBDB6", VA = "0xBDB6", Slot = "11")]
		protected override void OnInit(SimpleSpriteCloudWorldObjectArgs args)
		{
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D4")]
		[Address(RVA = "0xBDB7", Offset = "0xBDB7", VA = "0xBDB7")]
		public void OnOutOfRender()
		{
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D5")]
		[Address(RVA = "0xBDB8", Offset = "0xBDB8", VA = "0xBDB8")]
		public void UpdateOrder()
		{
		/* --- GHIDRA: UpdateOrder ---
		void CloudsFly_SimpleCloudSpriteWorldObject__UpdateOrder(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59693 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_WorldObject_SimpleSpriteCloudWorldObjectArgs___ctor__);
		    DAT_ram_00a59693 = '\x01';
		  }
		  CloudsFly_WorldObjectEngine_object___set_Args
		            (param1,Method_CloudsFly_WorldObject_SimpleSpriteCloudWorldObjectArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D6")]
		[Address(RVA = "0xBDB9", Offset = "0xBDB9", VA = "0xBDB9")]
		public SimpleCloudSpriteWorldObject()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_SimpleCloudSpriteWorldObject___ctor(int param1,int param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float fVar4;
		  float fVar5;
		  float fVar6;
		  int iVar7;
		  float fVar8;
		  float fVar9;
		  int param2_00;
		  float4 fVar10;
		  undefined4 param1_00;
		  undefined8 local_40;
		  undefined8 local_38;
		  float local_30;
		  float4 local_28;
		  undefined4 local_24;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  undefined1 auStack_10 [4];
		  undefined4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  fVar1 = 0.0;
		  fVar5 = *(float *)(param2 + 0x10);
		  fVar6 = *(float *)(param2 + 0xc);
		  iVar7 = *(int *)(param2 + 0x14);
		  fVar8 = *(float *)(param2 + 0x24);
		  fVar9 = *(float *)(param2 + 8);
		  param2_00 = *(int *)(param2 + 0x18);
		  if (param2_00 == 0) {
		    fVar10 = 0.0;
		  }
		  else {
		    UnityEngine_Sprite__get_bounds(auStack_10,param2_00,0);
		    fVar1 = local_8;
		    UnityEngine_Sprite__get_bounds(auStack_10,param2_00,0);
		    fVar10 = local_4;
		  }
		  if (DAT_ram_00a59694 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_SkinsV2_AbstractSkinResolver_SpriteRenderer__Sprite__Resolve__);
		    DAT_ram_00a59694 = '\x01';
		  }
		  iVar2 = func_ii_7884(*(undefined4 *)(param1 + 0x28),0);
		  if (iVar2 != param2_00) {
		    Core_Extensions_SpriteAtlasExt__TryGetSprite(*(undefined4 *)(param1 + 0x28),param2_00,0);
		    UI_SkinsV2_AbstractSkinResolver_object__object___OnEnable
		              (*(undefined4 *)(param1 + 0x2c),
		               Method_UI_SkinsV2_AbstractSkinResolver_SpriteRenderer__Sprite__Resolve__);
		  }
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x28),0);
		  fVar4 = (float)(**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                           (*(undefined4 *)(iVar7 + 0x20),(float)fVar1 * -2.0,
		                            (float)fVar1 + (float)fVar1,*(undefined4 *)(iVar7 + 0x14));
		  local_30 = fVar5 + 0.0;
		  local_18 = (float4)(fVar6 + (float)fVar10);
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar7 = (int)fVar4;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  local_1c = (float4)(fVar9 + (float)iVar7);
		  local_38 = CONCAT44(local_18,local_1c);
		  local_14 = (float4)local_30;
		  UnityEngine_Transform__get_position(uVar3,&local_38,0);
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_7888(auStack_10,uVar3,0);
		  if (ABS(-(float)local_8) < 2.1474836e+09) {
		    iVar7 = (int)-(float)local_8;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer(param1_00,iVar7,0);
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  UnityEngine_SpriteRenderer__InvokeSpriteChanged(auStack_10,uVar3,0);
		  local_28 = (float4)(fVar8 + (float)fVar1);
		  local_24 = local_c;
		  local_40 = CONCAT44(local_c,local_28);
		  UnityEngine_SpriteRenderer__get_size(uVar3,&local_40,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  UnityEngine_Object__op_Implicit(param1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4003CAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;
	}
}
