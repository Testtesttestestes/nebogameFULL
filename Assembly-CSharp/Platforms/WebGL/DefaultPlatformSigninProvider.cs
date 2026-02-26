using System;
using Core.Application.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Platforms.WebGL
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public class DefaultPlatformSigninProvider : AbstractPlatformSigninProvider
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x226B", Offset = "0x226B", VA = "0x226B")]
		public DefaultPlatformSigninProvider(ClientPlatform platform)
		{
		/* --- GHIDRA: .ctor ---
		void Platforms_WebGL_DefaultPlatformSigninProvider___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x5B1E", Offset = "0x5B1E", VA = "0x5B1E", Slot = "17")]
		public override UniTask<IPlatformSigninProvider> UpdateSigninRecord()
		{
		/* --- GHIDRA: UpdateSigninRecord ---
		void Platforms_WebGL_DefaultPlatformSigninProvider__UpdateSigninRecord
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b81f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Start_PlatformConfigurationProvider__Run_d__1___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__get_Task__
		              );
		    DAT_ram_00a5b81f = '\x01';
		  }
		  local_8 = 0;
		  local_18 = 0;
		  local_10 = 0;
		  local_20 = 0;
		  local_24 = 0xffffffff;
		  local_14 = param2;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Start_PlatformConfigurationProvider__Run_d__1___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__Start_PlatformConfigurationProvider__Run_d__1___
		              );
		  }
		  Platforms_WebGL_PlatformConfigurationProvider_ConfigParams___ctor(&local_24,&local_30);
		  unnamed_function_126403
		            (&local_30,&local_20,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformConfigurationProvider__get_Task__
		            );
		  *(undefined4 *)(param1 + 1) = local_28;
		  *param1 = local_30;
		  return;
		}
		*/

			return default(UniTask<IPlatformSigninProvider>);
		}
	}
}
