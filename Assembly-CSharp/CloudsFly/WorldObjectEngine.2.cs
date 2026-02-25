using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x02001312 RID: 4882
	[Token(Token = "0x2001312")]
	public abstract class WorldObjectEngine<T> : WorldObjectEngine where T : WorldObjectEngineArgs
	{
		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007402 RID: 29698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001761")]
		public T Args
		{
			[Token(Token = "0x6007401")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007402")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007403")]
		protected override void OnInit(WorldObjectEngineArgs args)
		{
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007404")]
		private void OnInitInternal(T args)
		{
		}

		// Token: 0x06007405 RID: 29701
		[Token(Token = "0x6007405")]
		protected abstract void OnInit(T args);

		// Token: 0x06007406 RID: 29702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007406")]
		protected WorldObjectEngine()
		{
		}
	}
}
