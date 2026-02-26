using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	public class FrescoFieldMini : FrescoField
	{
		// Token: 0x06002FDB RID: 12251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x8041", Offset = "0x8041", VA = "0x8041", Slot = "15")]
		protected override void ValidateSize(int sizeX, int sizeY, FrescoSpriteSelectorSO.SpriteSelectorElement spriteElement)
		{
		/* --- GHIDRA: ValidateSize ---
		void Gameplay_Fresco_View_FrescoFieldMini__ValidateSize(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57566 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoFragment___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FrescoFragment__TypeInfo);
		    DAT_ram_00a57566 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_FrescoFragment__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_FrescoFragment___ctor__);
		  *(undefined4 *)(param1 + 0x44) = param1_00;
		  AssetContent_Loaders_GameRawImageLoader__LoadAsset(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x8042", Offset = "0x8042", VA = "0x8042")]
		public FrescoFieldMini()
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Fresco_View_FrescoFieldMini___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (*(int *)(param1 + 0x24) == 0) {
		    uVar1 = (uint)(*(char *)(param1 + 0x20) == '\0');
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _field;
	}
}
