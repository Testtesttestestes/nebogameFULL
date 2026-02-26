using System;
using Core.Gameplay.Managers.Configuration;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Platforms.WebGL
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public class PlatformConfigurationProvider : AbstractPlatformConfigurationProvider
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x5B1F", Offset = "0x5B1F", VA = "0x5B1F", Slot = "11")]
		public override UniTask<IPlatformConfigurationProvider> Run()
		{
		/* --- GHIDRA: Run ---
		void Platforms_WebGL_PlatformConfigurationProvider__Run
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 auStack_30 [4];
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b820 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Start_PlatformConfigurationProvider__UpdateLaunchAppVars_d__2___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__get_Task__
		              );
		    DAT_ram_00a5b820 = '\x01';
		  }
		  local_4 = 0;
		  local_14 = 0;
		  local_c = 0;
		  local_1c = 0;
		  local_20 = 0xffffffff;
		  local_10 = param2;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Start_PlatformConfigurationProvider__UpdateLaunchAppVars_d__2___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Start_PlatformConfigurationProvider__UpdateLaunchAppVars_d__2___
		              );
		  }
		  Platforms_WebGL_PlatformConfigurationProvider__Run_d__1__SetStateMachine(&local_20,auStack_30);
		  unnamed_function_126403
		            (&local_2c,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__get_Task__
		            );
		  *(undefined4 *)(param1 + 1) = local_24;
		  *param1 = local_2c;
		  return;
		}
		*/

			return default(UniTask<IPlatformConfigurationProvider>);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x5B20", Offset = "0x5B20", VA = "0x5B20", Slot = "12")]
		public override UniTask<IPlatformConfigurationProvider> UpdateLaunchAppVars()
		{
			return default(UniTask<IPlatformConfigurationProvider>);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x225E", Offset = "0x225E", VA = "0x225E")]
		public PlatformConfigurationProvider()
		{
		}

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		[Serializable]
		private class ConfigParams
		{
			// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x5B21", Offset = "0x5B21", VA = "0x5B21")]
			public ConfigParams()
			{
			}

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			[FieldOffset(Offset = "0x8")]
			public string endpoint_uri;

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[FieldOffset(Offset = "0xC")]
			public int ping_timeout;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			[FieldOffset(Offset = "0x10")]
			public string cdn_uri;
		}
	}
}
