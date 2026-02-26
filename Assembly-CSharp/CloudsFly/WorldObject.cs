using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x0200130D RID: 4877
	[Token(Token = "0x200130D")]
	public abstract class WorldObject : BaseWorldObjectRenderer
	{
		// Token: 0x060073E9 RID: 29673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E9")]
		[Address(RVA = "0xBDCC", Offset = "0xBDCC", VA = "0xBDCC")]
		public void Init(WorldObjectArgs args)
		{
		}

		// Token: 0x060073EA RID: 29674
		[Token(Token = "0x60073EA")]
		protected abstract void OnInit(WorldObjectArgs args);

		// Token: 0x060073EB RID: 29675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073EB")]
		[Address(RVA = "0xBDCD", Offset = "0xBDCD", VA = "0xBDCD")]
		protected WorldObject()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_WorldObject___ctor(int param1,undefined8 *param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(param2 + 1);
		  *(undefined8 *)(param1 + 8) = *param2;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  return;
		}
		*/

		}
	}
}
