using System;
using Il2CppDummyDll;

namespace Utils.Wrappers
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class JsonWrappers
	{
		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x579B", Offset = "0x579B", VA = "0x579B")]
		public JsonWrappers()
		{
		/* --- GHIDRA: .ctor ---
		void Core_ExternalIncomingScriptCall_JsonWrappers___ctor(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  int param3;
		  
		  if (DAT_ram_00a54941 == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_AppsFlyer_TypeInfo);
		    DAT_ram_00a54941 = '\x01';
		  }
		  cVar1 = *(char *)(param1 + 0x20);
		  if (*(int *)(AppsFlyerSDK_AppsFlyer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(AppsFlyerSDK_AppsFlyer_TypeInfo);
		  }
		  AppsFlyerSDK_AppsFlyer__getSdkVersion((uint)(cVar1 != '\0'),param1);
		  cVar1 = *(char *)(param1 + 0x21);
		  if (*(int *)(AppsFlyerSDK_AppsFlyer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(AppsFlyerSDK_AppsFlyer_TypeInfo);
		  }
		  param3 = param1;
		  if (cVar1 == '\0') {
		    param3 = 0;
		  }
		  AppsFlyerSDK_AppsFlyer__initSDK(param1,param1,param3,param1);
		  AppsFlyerSDK_AppsFlyer__initSDK(param1);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Utils_Wrappers_JsonWrappers___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  float fVar1;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x20),0);
		  fVar1 = UnityEngine_Time__get_timeAsRational(0);
		  UnityEngine_Transform__Rotate(param1_00,0.0,0.0,fVar1 * 500.0,0);
		  return;
		}
		*/

		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public class GenericJsonWrapper<T>
		{
			// Token: 0x0600032B RID: 811 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600032B")]
			public virtual T GetValue(string jsonRaw)
			{
				return null;
			}

			// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600032C")]
			public GenericJsonWrapper()
			{
			}

			// Token: 0x0400016F RID: 367
			[Token(Token = "0x400016F")]
			[FieldOffset(Offset = "0x0")]
			public T Value;
		}

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		public class ArrayWrapper<T> : JsonWrappers.GenericJsonWrapper<T[]>
		{
			// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600032D")]
			public ArrayWrapper()
			{
			}
		}
	}
}
