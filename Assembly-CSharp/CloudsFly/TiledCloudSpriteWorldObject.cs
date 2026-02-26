using System;
using Il2CppDummyDll;
using UI.SkinsV2;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001305 RID: 4869
	[Token(Token = "0x2001305")]
	public class TiledCloudSpriteWorldObject : WorldObject<TiledSpriteCloudWorldObjectArgs>
	{
		// Token: 0x060073D7 RID: 29655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0xBDBA", Offset = "0xBDBA", VA = "0xBDBA", Slot = "11")]
		protected override void OnInit(TiledSpriteCloudWorldObjectArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void CloudsFly_TiledCloudSpriteWorldObject__OnInit(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  UnityEngine_Object__op_Implicit(param1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D8")]
		[Address(RVA = "0xBDBB", Offset = "0xBDBB", VA = "0xBDBB")]
		public void OnOutOfRender()
		{
		/* --- GHIDRA: OnOutOfRender ---
		void CloudsFly_TiledCloudSpriteWorldObject__OnOutOfRender(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int param2_01;
		  undefined1 auStack_c [8];
		  float4 local_4;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_7888(auStack_c,param2_00,0);
		  if (ABS(-(float)local_4) < 2.1474836e+09) {
		    param2_01 = (int)-(float)local_4;
		  }
		  else {
		    param2_01 = -0x80000000;
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer(param1_00,param2_01,0);
		  return;
		}
		*/

		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0xBDBC", Offset = "0xBDBC", VA = "0xBDBC")]
		public void UpdateOrder()
		{
		/* --- GHIDRA: UpdateOrder ---
		void CloudsFly_TiledCloudSpriteWorldObject__UpdateOrder(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59694 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_SkinsV2_AbstractSkinResolver_SpriteRenderer__Sprite__Resolve__);
		    DAT_ram_00a59694 = '\x01';
		  }
		  iVar1 = func_ii_7884(*(undefined4 *)(param1 + 0x28),0);
		  if (iVar1 != param2) {
		    Core_Extensions_SpriteAtlasExt__TryGetSprite(*(undefined4 *)(param1 + 0x28),param2,0);
		    UI_SkinsV2_AbstractSkinResolver_object__object___OnEnable
		              (*(undefined4 *)(param1 + 0x2c),
		               Method_UI_SkinsV2_AbstractSkinResolver_SpriteRenderer__Sprite__Resolve__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DA")]
		[Address(RVA = "0xBDBD", Offset = "0xBDBD", VA = "0xBDBD")]
		private void SetSprite(Sprite sprite)
		{
		/* --- GHIDRA: SetSprite ---
		void CloudsFly_TiledCloudSpriteWorldObject__SetSprite(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59695 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_WorldObject_TiledSpriteCloudWorldObjectArgs___ctor__);
		    DAT_ram_00a59695 = '\x01';
		  }
		  CloudsFly_WorldObjectEngine_object___set_Args
		            (param1,Method_CloudsFly_WorldObject_TiledSpriteCloudWorldObjectArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0xBDBE", Offset = "0xBDBE", VA = "0xBDBE")]
		public TiledCloudSpriteWorldObject()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_TiledCloudSpriteWorldObject___ctor
		               (int param1,undefined8 *param2,undefined4 param3,undefined4 param4,float param5,
		               float param6,float param7,undefined4 param8)
		
		{
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(param2 + 1);
		  *(undefined8 *)(param1 + 8) = *param2;
		  *(float *)(param1 + 0x24) = param7;
		  *(float *)(param1 + 0x20) = param6;
		  *(float *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  return;
		}
		*/

		}

		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4003CAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4003CAC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SpriteRenderSkinResolver _skinResolver;
	}
}
