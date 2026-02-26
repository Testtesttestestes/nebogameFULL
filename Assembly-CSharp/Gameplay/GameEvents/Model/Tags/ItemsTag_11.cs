using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	public class ItemsTag_11 : AbstractTag
	{
		// Token: 0x06002E83 RID: 11907 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x7EFE", Offset = "0x7EFE", VA = "0x7EFE", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x7EFF", Offset = "0x7EFF", VA = "0x7EFF")]
		public ItemsTag_11()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GameEvents_Model_Tags_ItemsTag_11___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  double dVar2;
		  
		  dVar2 = *(double *)(*(int *)(param1 + 0x14) + 0x10);
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar1 = (int)dVar2;
		  }
		  else {
		    iVar1 = -0x80000000;
		  }
		  return iVar1 + -1;
		}
		*/

		}
	}
}
