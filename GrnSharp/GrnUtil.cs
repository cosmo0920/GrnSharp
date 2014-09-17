using System;

public class GrnUtil
{
	public static grn_user_data grn_ctx_user_data(ref grn_ctx ctx){
		return ctx.user_data;
	}

	public static grn_encoding grn_ctx_get_encoding(ref grn_ctx ctx){
		return ctx.encoding;
	}

	public static grn_encoding grn_ctx_set_encoding(ref grn_ctx ctx, string encoding){
		return ctx.encoding = NativeMethods.grn_encoding_parse(encoding);
	}

	public static grn_rc grn_ctx_fix(ref grn_ctx ctx, ref grn_table_cursor obj) {
		grn_rc result;
		result = NativeMethods.grn_obj_close(ref ctx, ref obj);
		return result;
	}
}