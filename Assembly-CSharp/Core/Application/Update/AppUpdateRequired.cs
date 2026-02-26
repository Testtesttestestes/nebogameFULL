using System;
using Core.Application.Update.Common;
using Il2CppDummyDll;

namespace Core.Application.Update
{
	// Token: 0x02001238 RID: 4664
	[Token(Token = "0x2001238")]
	public class AppUpdateRequired : AbstractAppUpdateRequired
	{
		// Token: 0x06006EB2 RID: 28338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB2")]
		[Address(RVA = "0xB936", Offset = "0xB936", VA = "0xB936", Slot = "7")]
		public override void Run()
		{
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB3")]
		[Address(RVA = "0xB937", Offset = "0xB937", VA = "0xB937", Slot = "8")]
		public override void Stop()
		{
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB4")]
		[Address(RVA = "0xB938", Offset = "0xB938", VA = "0xB938")]
		public AppUpdateRequired()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Update_AppUpdateRequired___ctor(int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  param1[4] = 0;
		  param1[5] = 0;
		  param1[2] = 0;
		  param1[3] = 0;
		  return;
		}
		*/

		}
	}
}
