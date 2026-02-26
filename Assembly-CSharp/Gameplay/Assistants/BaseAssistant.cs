using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Assistants
{
	// Token: 0x02000CA5 RID: 3237
	[Token(Token = "0x2000CA5")]
	public abstract class BaseAssistant : IDisposable
	{
		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EBA RID: 20154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF0")]
		public AssistantsDic Dic
		{
			[Token(Token = "0x6004EB9")]
			[Address(RVA = "0x9CE5", Offset = "0x9CE5", VA = "0x9CE5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EBA")]
			[Address(RVA = "0x9CE6", Offset = "0x9CE6", VA = "0x9CE6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		// (set) Token: 0x06004EBC RID: 20156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF1")]
		public bool IsRun
		{
			[Token(Token = "0x6004EBB")]
			[Address(RVA = "0x9CE7", Offset = "0x9CE7", VA = "0x9CE7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004EBC")]
			[Address(RVA = "0x9CE8", Offset = "0x9CE8", VA = "0x9CE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x9CE9", Offset = "0x9CE9", VA = "0x9CE9", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Assistants_BaseAssistant__Dispose(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if ((char)param1[3] == '\0') {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		              (param1,param2,*(undefined4 *)(*param1 + 0xf4));
		    *(undefined1 *)(param1 + 3) = 1;
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_3027);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_Assistants_BaseAssistant_Run__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x9CEA", Offset = "0x9CEA", VA = "0x9CEA")]
		public void Run(AssistantStatus status)
		{
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x228E", Offset = "0x228E", VA = "0x228E")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		int * Gameplay_Assistants_BaseAssistant__Stop(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004EC0 RID: 20160
		[Token(Token = "0x6004EC0")]
		protected abstract void HandleRun(AssistantStatus status);

		// Token: 0x06004EC1 RID: 20161
		[Token(Token = "0x6004EC1")]
		protected abstract void HandleStop();

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x9CEB", Offset = "0x9CEB", VA = "0x9CEB")]
		protected BaseAssistant()
		{
		}
	}
}
