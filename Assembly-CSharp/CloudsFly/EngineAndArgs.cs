using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x020012FB RID: 4859
	[Token(Token = "0x20012FB")]
	[Serializable]
	public class EngineAndArgs
	{
		// Token: 0x060073A9 RID: 29609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A9")]
		[Address(RVA = "0xBD90", Offset = "0xBD90", VA = "0xBD90")]
		public EngineAndArgs(IWorldObjectEngine engine, WorldObjectEngineArgs args)
		{
		/* --- GHIDRA: .ctor ---
		int CloudsFly_EngineAndArgs___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59681 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsWorldObjectEngine_TypeInfo);
		    DAT_ram_00a59681 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(CloudsFly_CloudsWorldObjectEngine_TypeInfo);
		  if (DAT_ram_00a59691 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TiledCloudSpriteWorldObject__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_WorldObjectEngine_CloudWorldObjectEngineArgs___ctor__);
		    DAT_ram_00a59691 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_TiledCloudSpriteWorldObject__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject___ctor__);
		  *(undefined4 *)(iVar1 + 0x2c) = param1_00;
		  return iVar1;
		}
		*/

		}

		// Token: 0x04003C8E RID: 15502
		[Token(Token = "0x4003C8E")]
		[FieldOffset(Offset = "0x8")]
		public IWorldObjectEngine engine;

		// Token: 0x04003C8F RID: 15503
		[Token(Token = "0x4003C8F")]
		[FieldOffset(Offset = "0xC")]
		public WorldObjectEngineArgs args;
	}
}
