using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068E RID: 1678
	[Token(Token = "0x200068E")]
	public class ArtifactCategoryData
	{
		// Token: 0x0600288A RID: 10378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x1DE2", Offset = "0x1DE2", VA = "0x1DE2")]
		public ArtifactCategoryData()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Inventory_View_Chest_ArtifactCategoryData___ctor(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x28);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x39) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x0400165F RID: 5727
		[Token(Token = "0x400165F")]
		[FieldOffset(Offset = "0x8")]
		public uint SubFilterId;

		// Token: 0x04001660 RID: 5728
		[Token(Token = "0x4001660")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04001661 RID: 5729
		[Token(Token = "0x4001661")]
		[FieldOffset(Offset = "0x10")]
		public IList<ArtifactData> Items;

		// Token: 0x04001662 RID: 5730
		[Token(Token = "0x4001662")]
		[FieldOffset(Offset = "0x14")]
		public ArtifactView.ArtifactViewArgs.ArtifactViewOptions ExtraArtifactViewOptions;
	}
}
