using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B3 RID: 4531
	[Token(Token = "0x20011B3")]
	public abstract class AbstractBaseNotificationScheduler : IDisposable
	{
		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06006BA0 RID: 27552
		[Token(Token = "0x170015F6")]
		public abstract int Id { [Token(Token = "0x6006BA0")] get; }

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06006BA1 RID: 27553
		[Token(Token = "0x170015F7")]
		protected abstract bool IsNotificationEnabled { [Token(Token = "0x6006BA1")] get; }

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06006BA2 RID: 27554
		[Token(Token = "0x170015F8")]
		protected abstract LocalNotifications Channel { [Token(Token = "0x6006BA2")] get; }

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BA4 RID: 27556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F9")]
		private protected IApp App
		{
			[Token(Token = "0x6006BA3")]
			[Address(RVA = "0xB69A", Offset = "0xB69A", VA = "0xB69A")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006BA4")]
			[Address(RVA = "0xB69B", Offset = "0xB69B", VA = "0xB69B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06006BA5 RID: 27557 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BA6 RID: 27558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015FA")]
		private protected IGame Game
		{
			[Token(Token = "0x6006BA5")]
			[Address(RVA = "0xB69C", Offset = "0xB69C", VA = "0xB69C")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006BA6")]
			[Address(RVA = "0xB69D", Offset = "0xB69D", VA = "0xB69D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BA7")]
		[Address(RVA = "0x221C", Offset = "0x221C", VA = "0x221C")]
		public void Init(IApp app, IGame game)
		{
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BA8")]
		[Address(RVA = "0x2223", Offset = "0x2223", VA = "0x2223", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int * Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__Dispose
		                (int *param1)
		
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

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BA9")]
		[Address(RVA = "0xB69E", Offset = "0xB69E", VA = "0xB69E")]
		private void NotificationEnabledChangedEvent(uint notificationId)
		{
		/* --- GHIDRA: NotificationEnabledChangedEvent ---
		undefined4
		Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a691 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25656);
		    DAT_ram_00a5a691 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  func_ii_2946(param1_00,StringLiteral_25656,param1_00,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006BAA")]
		[Address(RVA = "0xB69F", Offset = "0xB69F", VA = "0xB69F")]
		protected Dictionary<string, object> GetDefaultDeveloperPayload(LocalNotificationDic dic)
		{
			return null;
		}

		// Token: 0x06006BAB RID: 27563
		[Token(Token = "0x6006BAB")]
		protected abstract void HandleInit();

		// Token: 0x06006BAC RID: 27564
		[Token(Token = "0x6006BAC")]
		protected abstract void HandleDispose();

		// Token: 0x06006BAD RID: 27565
		[Token(Token = "0x6006BAD")]
		protected abstract void OnSettingsChanged(uint notificationId);

		// Token: 0x06006BAE RID: 27566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BAE")]
		[Address(RVA = "0xB6A0", Offset = "0xB6A0", VA = "0xB6A0")]
		protected AbstractBaseNotificationScheduler()
		{
		}
	}
}
