using System;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EAA RID: 3754
	[Token(Token = "0x2000EAA")]
	public interface IConnection
	{
		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06005B35 RID: 23349
		// (set) Token: 0x06005B36 RID: 23350
		[Token(Token = "0x17001295")]
		Uri Uri { [Token(Token = "0x6005B35")] get; [Token(Token = "0x6005B36")] set; }

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06005B37 RID: 23351
		// (set) Token: 0x06005B38 RID: 23352
		[Token(Token = "0x17001296")]
		int WriteTimeout { [Token(Token = "0x6005B37")] get; [Token(Token = "0x6005B38")] set; }

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06005B39 RID: 23353
		// (set) Token: 0x06005B3A RID: 23354
		[Token(Token = "0x17001297")]
		int ReadTimeout { [Token(Token = "0x6005B39")] get; [Token(Token = "0x6005B3A")] set; }

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06005B3B RID: 23355
		[Token(Token = "0x17001298")]
		ConnectionState CurrentState { [Token(Token = "0x6005B3B")] get; }

		// Token: 0x1400022A RID: 554
		// (add) Token: 0x06005B3C RID: 23356
		// (remove) Token: 0x06005B3D RID: 23357
		[Token(Token = "0x1400022A")]
		event Action<ConnectionState> OnStateChangedEvent;

		// Token: 0x06005B3E RID: 23358
		[Token(Token = "0x6005B3E")]
		void Push(SrvCommand command);

		// Token: 0x06005B3F RID: 23359
		[Token(Token = "0x6005B3F")]
		void AddServiceEventHandler(short serviceId, Action<SrvAnswer> handler);

		// Token: 0x06005B40 RID: 23360
		[Token(Token = "0x6005B40")]
		void RemoveServiceEventHandler(short serviceId, Action<SrvAnswer> handler);

		// Token: 0x06005B41 RID: 23361
		[Token(Token = "0x6005B41")]
		void Run();

		// Token: 0x06005B42 RID: 23362
		[Token(Token = "0x6005B42")]
		void Stop();
	}
}
