using System;

public partial class UnsupportedConstant
{
	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_CTX_USER_DATA -> "(ctx) (&((ctx)->user_data))"
	public const string GRN_CTX_USER_DATA = "(ctx) (&((ctx)->user_data))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_CTX_GET_ENCODING -> "(ctx) ((ctx)->encoding)"
	public const string GRN_CTX_GET_ENCODING = "(ctx) ((ctx)->encoding)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_CTX_SET_ENCODING -> "(ctx,enc) ((ctx)->encoding = (enc == GRN_ENC_DEFAULT) ? grn_get_default_encoding() : enc)"
	public const string GRN_CTX_SET_ENCODING = "(ctx,enc) ((ctx)->encoding = (enc == GRN_ENC_DEFAULT) ? grn_get_default_encoding(" +
		") : enc)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_OBJ_INIT -> "(obj,obj_type,obj_flags,obj_domain) do { 
	///  (obj)->header.type = (obj_type);
	///  (obj)->header.impl_flags = (obj_flags);
	///  (obj)->header.flags = 0;
	///  (obj)->header.domain = (obj_domain);
	///  (obj)->u.b.head = NULL;
	///  (obj)->u.b.curr = NULL;
	///  (obj)->u.b.tail = NULL;
	///} while (0)"
	public const string GRN_OBJ_INIT = @"(obj,obj_type,obj_flags,obj_domain) do { 
  (obj)->header.type = (obj_type);
  (obj)->header.impl_flags = (obj_flags);
  (obj)->header.flags = 0;
  (obj)->header.domain = (obj_domain);
  (obj)->u.b.head = NULL;
  (obj)->u.b.curr = NULL;
  (obj)->u.b.tail = NULL;
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_OBJ_FIN -> "(ctx,obj) (grn_obj_close((ctx), (obj)))"
	public const string GRN_OBJ_FIN = "(ctx,obj) (grn_obj_close((ctx), (obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_DB_OPEN_OR_CREATE -> "(ctx,path,optarg,db) (((db) = grn_db_open((ctx), (path))) || (db = grn_db_create((ctx), (path), (optarg))))"
	public const string GRN_DB_OPEN_OR_CREATE = "(ctx,path,optarg,db) (((db) = grn_db_open((ctx), (path))) || (db = grn_db_create(" +
		"(ctx), (path), (optarg))))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TABLE_OPEN_OR_CREATE -> "(ctx,name,name_size,path,flags,key_type,value_type,table) (((table) = grn_ctx_get((ctx), (name), (name_size))) ||
	///   ((table) = grn_table_create((ctx), (name), (name_size), (path), (flags), (key_type), (value_type))))"
	public const string GRN_TABLE_OPEN_OR_CREATE = "(ctx,name,name_size,path,flags,key_type,value_type,table) (((table) = grn_ctx_get" +
		"((ctx), (name), (name_size))) ||\r\n   ((table) = grn_table_create((ctx), (name), " +
			"(name_size), (path), (flags), (key_type), (value_type))))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TABLE_EACH -> "(ctx,table,head,tail,id,key,key_size,value,block) do {
	///  (ctx)->errlvl = GRN_LOG_NOTICE;
	///  (ctx)->rc = GRN_SUCCESS;
	///  if ((ctx)->seqno & 1) {
	///    (ctx)->subno++;
	///  } else {
	///    (ctx)->seqno++;
	///  }
	///  if (table) {
	///    switch ((table)->header.type) {
	///    case GRN_TABLE_PAT_KEY :
	///      GRN_PAT_EACH((ctx), (grn_pat *)(table), (id), (key), (key_size), (value), block);
	///      break;
	///    case GRN_TABLE_DAT_KEY :
	///      GRN_DAT_EACH((ctx), (grn_dat *)(table), (id), (key), (key_size), block);
	///      break;
	///    case GRN_TABLE_HASH_KEY :
	///      GRN_HASH_EACH((ctx), (grn_hash *)(table), (id), (key), (key_size), (value), block);
	///      break;
	///    case GRN_TABLE_NO_KEY :
	///      GRN_ARRAY_EACH((ctx), (grn_array *)(table), (head), (tail), (id), (value), block);
	///      break;
	///    }
	///  }
	///  if ((ctx)->subno) {
	///    (ctx)->subno--;
	///  } else {
	///    (ctx)->seqno++;
	///  }
	///} while (0)"
	public const string GRN_TABLE_EACH = @"(ctx,table,head,tail,id,key,key_size,value,block) do {
  (ctx)->errlvl = GRN_LOG_NOTICE;
  (ctx)->rc = GRN_SUCCESS;
  if ((ctx)->seqno & 1) {
    (ctx)->subno++;
  } else {
    (ctx)->seqno++;
  }
  if (table) {
    switch ((table)->header.type) {
    case GRN_TABLE_PAT_KEY :
      GRN_PAT_EACH((ctx), (grn_pat *)(table), (id), (key), (key_size), (value), block);
      break;
    case GRN_TABLE_DAT_KEY :
      GRN_DAT_EACH((ctx), (grn_dat *)(table), (id), (key), (key_size), block);
      break;
    case GRN_TABLE_HASH_KEY :
      GRN_HASH_EACH((ctx), (grn_hash *)(table), (id), (key), (key_size), (value), block);
      break;
    case GRN_TABLE_NO_KEY :
      GRN_ARRAY_EACH((ctx), (grn_array *)(table), (head), (tail), (id), (value), block);
      break;
    }
  }
  if ((ctx)->subno) {
    (ctx)->subno--;
  } else {
    (ctx)->seqno++;
  }
} while (0)";
	/// GRN_COLUMN_NAME_ID_LEN -> (sizeof(GRN_COLUMN_NAME_ID) - 1)
	/// Error generating expression: Error generating function call.  Operation not implemented
	public const string GRN_COLUMN_NAME_ID_LEN = "(sizeof(GRN_COLUMN_NAME_ID) - 1)";

	/// GRN_COLUMN_NAME_KEY_LEN -> (sizeof(GRN_COLUMN_NAME_KEY) - 1)
	/// Error generating expression: Error generating function call.  Operation not implemented
	public const string GRN_COLUMN_NAME_KEY_LEN = "(sizeof(GRN_COLUMN_NAME_KEY) - 1)";

	/// GRN_COLUMN_NAME_VALUE_LEN -> (sizeof(GRN_COLUMN_NAME_VALUE) - 1)
	/// Error generating expression: Error generating function call.  Operation not implemented
	public const string GRN_COLUMN_NAME_VALUE_LEN = "(sizeof(GRN_COLUMN_NAME_VALUE) - 1)";

	/// GRN_COLUMN_NAME_SCORE_LEN -> (sizeof(GRN_COLUMN_NAME_SCORE) - 1)
	/// Error generating expression: Error generating function call.  Operation not implemented
	public const string GRN_COLUMN_NAME_SCORE_LEN = "(sizeof(GRN_COLUMN_NAME_SCORE) - 1)";

	/// GRN_COLUMN_NAME_NSUBRECS_LEN -> (sizeof(GRN_COLUMN_NAME_NSUBRECS) - 1)
	/// Error generating expression: Error generating function call.  Operation not implemented
	public const string GRN_COLUMN_NAME_NSUBRECS_LEN = "(sizeof(GRN_COLUMN_NAME_NSUBRECS) - 1)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_COLUMN_OPEN_OR_CREATE -> "(ctx,table,name,name_size,path,flags,type,column) (((column) = grn_obj_column((ctx), (table), (name), (name_size))) ||
	///   ((column) = grn_column_create((ctx), (table), (name), (name_size), (path), (flags), (type))))"
	public const string GRN_COLUMN_OPEN_OR_CREATE = "(ctx,table,name,name_size,path,flags,type,column) (((column) = grn_obj_column((ct" +
		"x), (table), (name), (name_size))) ||\r\n   ((column) = grn_column_create((ctx), (" +
			"table), (name), (name_size), (path), (flags), (type))))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_COLUMN_EACH -> "(ctx,column,id,value,block) do {
	///  int _n;
	///  grn_id id = 1;
	///  while ((_n = grn_obj_get_values(ctx, column, id, (void **)&value)) > 0) {
	///    for (; _n; _n--, id++, value++) {
	///      block
	///    }
	///  }
	///} while (0)"
	public const string GRN_COLUMN_EACH = "(ctx,column,id,value,block) do {\r\n  int _n;\r\n  grn_id id = 1;\r\n  while ((_n = grn" +
		"_obj_get_values(ctx, column, id, (void **)&value)) > 0) {\r\n    for (; _n; _n--, " +
			"id++, value++) {\r\n      block\r\n    }\r\n  }\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_OBJ_GET_DOMAIN -> "(obj) ((obj)->header.type == GRN_TABLE_NO_KEY ? GRN_ID_NIL : (obj)->header.domain)"
	public const string GRN_OBJ_GET_DOMAIN = "(obj) ((obj)->header.type == GRN_TABLE_NO_KEY ? GRN_ID_NIL : (obj)->header.domain" +
		")";

	/// GRN_ATTRIBUTE_PRINTF -> (fmt_pos)
	/// Error generating expression: Value fmt_pos is not resolved
	public const string GRN_ATTRIBUTE_PRINTF = "(fmt_pos)";

	/// GRN_SNIP_MAPPING_HTML_ESCAPE -> ((grn_snip_mapping *)-1)
	/// Error generating expression: Expression is not parsable.  Treating value as a raw string
	public const string GRN_SNIP_MAPPING_HTML_ESCAPE = "((grn_snip_mapping *)-1)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_LOG -> "(ctx,level) do {
	///  if (grn_logger_pass(ctx, level)) {
	///    grn_logger_put(ctx, (level), __FILE__, __LINE__, __FUNCTION__, __VA_ARGS__); 
	///  }
	///} while (0)"
	public const string GRN_LOG = "(ctx,level) do {\r\n  if (grn_logger_pass(ctx, level)) {\r\n    grn_logger_put(ctx, (" +
		"level), __FILE__, __LINE__, __FUNCTION__, __VA_ARGS__); \r\n  }\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_QUERY_LOG -> "(ctx,flag,mark,format) do {
	///  if (grn_query_logger_pass(ctx, flag)) {
	///    grn_query_logger_put(ctx, (flag), (mark), format, __VA_ARGS__);
	///  }
	///} while (0)"
	public const string GRN_QUERY_LOG = "(ctx,flag,mark,format) do {\r\n  if (grn_query_logger_pass(ctx, flag)) {\r\n    grn_q" +
		"uery_logger_put(ctx, (flag), (mark), format, __VA_ARGS__);\r\n  }\r\n} while (0)";

	/// GRN_BULK_BUFSIZE -> (sizeof(grn_obj) - sizeof(grn_obj_header))
	/// Error generating expression: Error generating function call.  Operation not implemented
	public const string GRN_BULK_BUFSIZE = "(sizeof(grn_obj) - sizeof(grn_obj_header))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_SIZE_IN_FLAGS -> "(flags) ((flags) & GRN_BULK_BUFSIZE_MAX)"
	public const string GRN_BULK_SIZE_IN_FLAGS = "(flags) ((flags) & GRN_BULK_BUFSIZE_MAX)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_OUTP -> "(bulk) ((bulk)->header.impl_flags & GRN_OBJ_OUTPLACE)"
	public const string GRN_BULK_OUTP = "(bulk) ((bulk)->header.impl_flags & GRN_OBJ_OUTPLACE)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_REWIND -> "(bulk) do {
	///  if ((bulk)->header.type == GRN_VECTOR) {
	///    grn_obj *_body = (bulk)->u.v.body;
	///    if (_body) {
	///      if (GRN_BULK_OUTP(_body)) {
	///        (_body)->u.b.curr = (_body)->u.b.head;
	///      } else {
	///        (_body)->header.flags &= ~GRN_BULK_BUFSIZE_MAX;
	///      }
	///    }
	///    (bulk)->u.v.n_sections = 0;
	///  } else {
	///    if (GRN_BULK_OUTP(bulk)) {
	///      (bulk)->u.b.curr = (bulk)->u.b.head;
	///    } else {
	///      (bulk)->header.flags &= ~GRN_BULK_BUFSIZE_MAX;
	///    }
	///  }
	///} while (0)"
	public const string GRN_BULK_REWIND = @"(bulk) do {
  if ((bulk)->header.type == GRN_VECTOR) {
    grn_obj *_body = (bulk)->u.v.body;
    if (_body) {
      if (GRN_BULK_OUTP(_body)) {
        (_body)->u.b.curr = (_body)->u.b.head;
      } else {
        (_body)->header.flags &= ~GRN_BULK_BUFSIZE_MAX;
      }
    }
    (bulk)->u.v.n_sections = 0;
  } else {
    if (GRN_BULK_OUTP(bulk)) {
      (bulk)->u.b.curr = (bulk)->u.b.head;
    } else {
      (bulk)->header.flags &= ~GRN_BULK_BUFSIZE_MAX;
    }
  }
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_WSIZE -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.tail - (bulk)->u.b.head)
	///   : GRN_BULK_BUFSIZE)"
	public const string GRN_BULK_WSIZE = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.tail - (bulk)->u.b.head)\r\n   : GRN" +
		"_BULK_BUFSIZE)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_REST -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.tail - (bulk)->u.b.curr)
	///   : GRN_BULK_BUFSIZE - (bulk)->header.flags)"
	public const string GRN_BULK_REST = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.tail - (bulk)->u.b.curr)\r\n   : GRN" +
		"_BULK_BUFSIZE - (bulk)->header.flags)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_VSIZE -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.curr - (bulk)->u.b.head)
	///   : GRN_BULK_SIZE_IN_FLAGS((bulk)->header.flags))"
	public const string GRN_BULK_VSIZE = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.curr - (bulk)->u.b.head)\r\n   : GRN" +
		"_BULK_SIZE_IN_FLAGS((bulk)->header.flags))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_EMPTYP -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.curr == (bulk)->u.b.head)
	///   : !(GRN_BULK_SIZE_IN_FLAGS((bulk)->header.flags)))"
	public const string GRN_BULK_EMPTYP = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.curr == (bulk)->u.b.head)\r\n   : !(" +
		"GRN_BULK_SIZE_IN_FLAGS((bulk)->header.flags)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_HEAD -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.head)
	///   : (char *)&((bulk)->u.b.head))"
	public const string GRN_BULK_HEAD = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.head)\r\n   : (char *)&((bulk)->u.b." +
		"head))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_CURR -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.curr)
	///   : (char *)&((bulk)->u.b.head) + GRN_BULK_SIZE_IN_FLAGS((bulk)->header.flags))"
	public const string GRN_BULK_CURR = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.curr)\r\n   : (char *)&((bulk)->u.b." +
		"head) + GRN_BULK_SIZE_IN_FLAGS((bulk)->header.flags))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BULK_TAIL -> "(bulk) (GRN_BULK_OUTP(bulk)
	///   ? ((bulk)->u.b.tail)
	///   : (char *)&((bulk)[1]))"
	public const string GRN_BULK_TAIL = "(bulk) (GRN_BULK_OUTP(bulk)\r\n   ? ((bulk)->u.b.tail)\r\n   : (char *)&((bulk)[1]))";

	
	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_OBJ_FORMAT_INIT -> "(format,format_nhits,format_offset,format_limit,format_hits_offset) do { 
	///  GRN_PTR_INIT(&(format)->columns, GRN_OBJ_VECTOR, GRN_ID_NIL);
	///  (format)->nhits = (format_nhits);
	///  (format)->offset = (format_offset);
	///  (format)->limit = (format_limit);
	///  (format)->hits_offset = (format_hits_offset);
	///  (format)->flags = 0;
	///  (format)->expression = NULL;
	///} while (0)"
	public const string GRN_OBJ_FORMAT_INIT = @"(format,format_nhits,format_offset,format_limit,format_hits_offset) do { 
  GRN_PTR_INIT(&(format)->columns, GRN_OBJ_VECTOR, GRN_ID_NIL);
  (format)->nhits = (format_nhits);
  (format)->offset = (format_offset);
  (format)->limit = (format_limit);
  (format)->hits_offset = (format_hits_offset);
  (format)->flags = 0;
  (format)->expression = NULL;
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_OBJ_FORMAT_FIN -> "(ctx,format) do {
	///  int ncolumns = GRN_BULK_VSIZE(&(format)->columns) / sizeof(grn_obj *);
	///  grn_obj **columns = (grn_obj **)GRN_BULK_HEAD(&(format)->columns);
	///  while (ncolumns--) { grn_obj_unlink((ctx), *columns++); }
	///  GRN_OBJ_FIN((ctx), &(format)->columns);
	///  if ((format)->expression) { GRN_OBJ_FIN((ctx), (format)->expression); } 
	///} while (0)"
	public const string GRN_OBJ_FORMAT_FIN = @"(ctx,format) do {
  int ncolumns = GRN_BULK_VSIZE(&(format)->columns) / sizeof(grn_obj *);
  grn_obj **columns = (grn_obj **)GRN_BULK_HEAD(&(format)->columns);
  while (ncolumns--) { grn_obj_unlink((ctx), *columns++); }
  GRN_OBJ_FIN((ctx), &(format)->columns);
  if ((format)->expression) { GRN_OBJ_FIN((ctx), (format)->expression); } 
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_OBJ_MUTABLE -> "(obj) ((obj) && (obj)->header.type <= GRN_VECTOR)"
	public const string GRN_OBJ_MUTABLE = "(obj) ((obj) && (obj)->header.type <= GRN_VECTOR)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_VALUE_FIX_SIZE_INIT -> "(obj,flags,domain) GRN_OBJ_INIT((obj), ((flags) & GRN_OBJ_VECTOR) ? GRN_UVECTOR : GRN_BULK,
	///               ((flags) & GRN_OBJ_DO_SHALLOW_COPY), (domain))"
	public const string GRN_VALUE_FIX_SIZE_INIT = "(obj,flags,domain) GRN_OBJ_INIT((obj), ((flags) & GRN_OBJ_VECTOR) ? GRN_UVECTOR :" +
		" GRN_BULK,\r\n               ((flags) & GRN_OBJ_DO_SHALLOW_COPY), (domain))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_VALUE_VAR_SIZE_INIT -> "(obj,flags,domain) GRN_OBJ_INIT((obj), ((flags) & GRN_OBJ_VECTOR) ? GRN_VECTOR : GRN_BULK,
	///               ((flags) & GRN_OBJ_DO_SHALLOW_COPY), (domain))"
	public const string GRN_VALUE_VAR_SIZE_INIT = "(obj,flags,domain) GRN_OBJ_INIT((obj), ((flags) & GRN_OBJ_VECTOR) ? GRN_VECTOR : " +
		"GRN_BULK,\r\n               ((flags) & GRN_OBJ_DO_SHALLOW_COPY), (domain))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_VOID_INIT -> "(obj) GRN_OBJ_INIT((obj), GRN_VOID, 0, GRN_DB_VOID)"
	public const string GRN_VOID_INIT = "(obj) GRN_OBJ_INIT((obj), GRN_VOID, 0, GRN_DB_VOID)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_INIT -> "(obj,flags) GRN_VALUE_VAR_SIZE_INIT(obj, flags, GRN_DB_TEXT)"
	public const string GRN_TEXT_INIT = "(obj,flags) GRN_VALUE_VAR_SIZE_INIT(obj, flags, GRN_DB_TEXT)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_SHORT_TEXT_INIT -> "(obj,flags) GRN_VALUE_VAR_SIZE_INIT(obj, flags, GRN_DB_SHORT_TEXT)"
	public const string GRN_SHORT_TEXT_INIT = "(obj,flags) GRN_VALUE_VAR_SIZE_INIT(obj, flags, GRN_DB_SHORT_TEXT)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_LONG_TEXT_INIT -> "(obj,flags) GRN_VALUE_VAR_SIZE_INIT(obj, flags, GRN_DB_LONG_TEXT)"
	public const string GRN_LONG_TEXT_INIT = "(obj,flags) GRN_VALUE_VAR_SIZE_INIT(obj, flags, GRN_DB_LONG_TEXT)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_SET_REF -> "(obj,str,len) do {
	///  (obj)->u.b.head = (char *)(str);
	///  (obj)->u.b.curr = (char *)(str) + (len);
	///} while (0)"
	public const string GRN_TEXT_SET_REF = "(obj,str,len) do {\r\n  (obj)->u.b.head = (char *)(str);\r\n  (obj)->u.b.curr = (char" +
		" *)(str) + (len);\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_SET -> "(ctx,obj,str,len) do {
	///  if ((obj)->header.impl_flags & GRN_OBJ_REFER) {
	///    GRN_TEXT_SET_REF((obj), (str), (len));
	///  } else {
	///    grn_bulk_write_from((ctx), (obj), (const char *)(str), 0, (unsigned int)(len));
	///  }
	///} while (0)"
	public const string GRN_TEXT_SET = "(ctx,obj,str,len) do {\r\n  if ((obj)->header.impl_flags & GRN_OBJ_REFER) {\r\n    GR" +
		"N_TEXT_SET_REF((obj), (str), (len));\r\n  } else {\r\n    grn_bulk_write_from((ctx)," +
			" (obj), (const char *)(str), 0, (unsigned int)(len));\r\n  }\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_PUT -> "(ctx,obj,str,len) grn_bulk_write((ctx), (obj), (const char *)(str), (unsigned int)(len))"
	public const string GRN_TEXT_PUT = "(ctx,obj,str,len) grn_bulk_write((ctx), (obj), (const char *)(str), (unsigned int" +
		")(len))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_PUTC -> "(ctx,obj,c) do {
	///  char _c = (c); grn_bulk_write((ctx), (obj), &_c, 1);
	///} while (0)"
	public const string GRN_TEXT_PUTC = "(ctx,obj,c) do {\r\n  char _c = (c); grn_bulk_write((ctx), (obj), &_c, 1);\r\n} while" +
		" (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_PUTS -> "(ctx,obj,str) GRN_TEXT_PUT((ctx), (obj), (str), strlen(str))"
	public const string GRN_TEXT_PUTS = "(ctx,obj,str) GRN_TEXT_PUT((ctx), (obj), (str), strlen(str))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_SETS -> "(ctx,obj,str) GRN_TEXT_SET((ctx), (obj), (str), strlen(str))"
	public const string GRN_TEXT_SETS = "(ctx,obj,str) GRN_TEXT_SET((ctx), (obj), (str), strlen(str))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_VALUE -> "(obj) GRN_BULK_HEAD(obj)"
	public const string GRN_TEXT_VALUE = "(obj) GRN_BULK_HEAD(obj)";

	
	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TEXT_LEN -> "(obj) GRN_BULK_VSIZE(obj)"
	public const string GRN_TEXT_LEN = "(obj) GRN_BULK_VSIZE(obj)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BOOL_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_BOOL)"
	public const string GRN_BOOL_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_BOOL)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT8_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT8)"
	public const string GRN_INT8_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT8)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT8_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT8)"
	public const string GRN_UINT8_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT8)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT16_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT16)"
	public const string GRN_INT16_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT16)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT16_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT16)"
	public const string GRN_UINT16_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT16)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT32_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT32)"
	public const string GRN_INT32_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT32)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT32_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT32)"
	public const string GRN_UINT32_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT32)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT64_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT64)"
	public const string GRN_INT64_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_INT64)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT64_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT64)"
	public const string GRN_UINT64_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_UINT64)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_FLOAT_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_FLOAT)"
	public const string GRN_FLOAT_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_FLOAT)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TIME_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_TIME)"
	public const string GRN_TIME_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_TIME)";

	/// GRN_RECORD_INIT -> GRN_VALUE_FIX_SIZE_INIT
	public const string GRN_RECORD_INIT = UnsupportedConstant.GRN_VALUE_FIX_SIZE_INIT;

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PTR_INIT -> "(obj,flags,domain) GRN_OBJ_INIT((obj), ((flags) & GRN_OBJ_VECTOR) ? GRN_PVECTOR : GRN_PTR,
	///               ((flags) & GRN_OBJ_DO_SHALLOW_COPY), (domain))"
	public const string GRN_PTR_INIT = "(obj,flags,domain) GRN_OBJ_INIT((obj), ((flags) & GRN_OBJ_VECTOR) ? GRN_PVECTOR :" +
		" GRN_PTR,\r\n               ((flags) & GRN_OBJ_DO_SHALLOW_COPY), (domain))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TOKYO_GEO_POINT_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_TOKYO_GEO_POINT)"
	public const string GRN_TOKYO_GEO_POINT_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_TOKYO_GEO_POINT)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_WGS84_GEO_POINT_INIT -> "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_WGS84_GEO_POINT)"
	public const string GRN_WGS84_GEO_POINT_INIT = "(obj,flags) GRN_VALUE_FIX_SIZE_INIT(obj, flags, GRN_DB_WGS84_GEO_POINT)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BOOL_SET -> "(ctx,obj,val) do {
	///  unsigned char _val = (unsigned char)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned char));
	///} while (0)"
	public const string GRN_BOOL_SET = "(ctx,obj,val) do {\r\n  unsigned char _val = (unsigned char)(val);\r\n  grn_bulk_writ" +
		"e_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT8_SET -> "(ctx,obj,val) do {
	///  signed char _val = (signed char)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(signed char));
	///} while (0)"
	public const string GRN_INT8_SET = "(ctx,obj,val) do {\r\n  signed char _val = (signed char)(val);\r\n  grn_bulk_write_fr" +
		"om((ctx), (obj), (char *)&_val, 0, sizeof(signed char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT8_SET -> "(ctx,obj,val) do {
	///  unsigned char _val = (unsigned char)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned char));
	///} while (0)"
	public const string GRN_UINT8_SET = "(ctx,obj,val) do {\r\n  unsigned char _val = (unsigned char)(val);\r\n  grn_bulk_writ" +
		"e_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT16_SET -> "(ctx,obj,val) do {
	///  signed short _val = (signed short)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(signed short));
	///} while (0)"
	public const string GRN_INT16_SET = "(ctx,obj,val) do {\r\n  signed short _val = (signed short)(val);\r\n  grn_bulk_write_" +
		"from((ctx), (obj), (char *)&_val, 0, sizeof(signed short));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT16_SET -> "(ctx,obj,val) do {
	///  unsigned short _val = (unsigned short)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned short));
	///} while (0)"
	public const string GRN_UINT16_SET = "(ctx,obj,val) do {\r\n  unsigned short _val = (unsigned short)(val);\r\n  grn_bulk_wr" +
		"ite_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned short));\r\n} while (0)";

	
	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT32_SET -> "(ctx,obj,val) do {
	///  int _val = (int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(int));
	///} while (0)"
	public const string GRN_INT32_SET = "(ctx,obj,val) do {\r\n  int _val = (int)(val);\r\n  grn_bulk_write_from((ctx), (obj)," +
		" (char *)&_val, 0, sizeof(int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT32_SET -> "(ctx,obj,val) do {
	///  unsigned int _val = (unsigned int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned int));
	///} while (0)"
	public const string GRN_UINT32_SET = "(ctx,obj,val) do {\r\n  unsigned int _val = (unsigned int)(val);\r\n  grn_bulk_write_" +
		"from((ctx), (obj), (char *)&_val, 0, sizeof(unsigned int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT64_SET -> "(ctx,obj,val) do {
	///  long long int _val = (long long int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(long long int));
	///} while (0)"
	public const string GRN_INT64_SET = "(ctx,obj,val) do {\r\n  long long int _val = (long long int)(val);\r\n  grn_bulk_writ" +
		"e_from((ctx), (obj), (char *)&_val, 0, sizeof(long long int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT64_SET -> "(ctx,obj,val) do {
	///  long long unsigned int _val = (long long unsigned int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(long long unsigned int));
	///} while (0)"
	public const string GRN_UINT64_SET = "(ctx,obj,val) do {\r\n  long long unsigned int _val = (long long unsigned int)(val)" +
		";\r\n  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(long long unsign" +
			"ed int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_FLOAT_SET -> "(ctx,obj,val) do {
	///  double _val = (double)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(double));
	///} while (0)"
	public const string GRN_FLOAT_SET = "(ctx,obj,val) do {\r\n  double _val = (double)(val);\r\n  grn_bulk_write_from((ctx), " +
		"(obj), (char *)&_val, 0, sizeof(double));\r\n} while (0)";

	/// GRN_TIME_SET -> GRN_INT64_SET
	public const string GRN_TIME_SET = UnsupportedConstant.GRN_INT64_SET;

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_RECORD_SET -> "(ctx,obj,val) do {
	///  grn_id _val = (grn_id)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(grn_id));
	///} while (0)"
	public const string GRN_RECORD_SET = "(ctx,obj,val) do {\r\n  grn_id _val = (grn_id)(val);\r\n  grn_bulk_write_from((ctx), " +
		"(obj), (char *)&_val, 0, sizeof(grn_id));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PTR_SET -> "(ctx,obj,val) do {
	///  grn_obj *_val = (grn_obj *)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(grn_obj *));
	///} while (0)"
	public const string GRN_PTR_SET = "(ctx,obj,val) do {\r\n  grn_obj *_val = (grn_obj *)(val);\r\n  grn_bulk_write_from((c" +
		"tx), (obj), (char *)&_val, 0, sizeof(grn_obj *));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_GEO_DEGREE2MSEC -> "(degree) ((int)((degree) * 3600 * 1000 + ((degree) > 0 ? 0.5 : -0.5)))"
	public const string GRN_GEO_DEGREE2MSEC = "(degree) ((int)((degree) * 3600 * 1000 + ((degree) > 0 ? 0.5 : -0.5)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_GEO_MSEC2DEGREE -> "(msec) ((((int)(msec)) / 3600.0) * 0.001)"
	public const string GRN_GEO_MSEC2DEGREE = "(msec) ((((int)(msec)) / 3600.0) * 0.001)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_GEO_POINT_SET -> "(ctx,obj,_latitude,_longitude) do {
	///  grn_geo_point _val;
	///  _val.latitude = (int)(_latitude);
	///  _val.longitude = (int)(_longitude);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val, 0, sizeof(grn_geo_point));
	///} while (0)"
	public const string GRN_GEO_POINT_SET = "(ctx,obj,_latitude,_longitude) do {\r\n  grn_geo_point _val;\r\n  _val.latitude = (in" +
		"t)(_latitude);\r\n  _val.longitude = (int)(_longitude);\r\n  grn_bulk_write_from((ct" +
			"x), (obj), (char *)&_val, 0, sizeof(grn_geo_point));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BOOL_SET_AT -> "(ctx,obj,offset,val) do {
	///  unsigned char _val = (unsigned char)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset), sizeof(unsigned char));
	///} while (0)"
	public const string GRN_BOOL_SET_AT = "(ctx,obj,offset,val) do {\r\n  unsigned char _val = (unsigned char)(val);\r\n  grn_bu" +
		"lk_write_from((ctx), (obj), (char *)&_val,\r\n                      (offset), size" +
			"of(unsigned char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT8_SET_AT -> "(ctx,obj,offset,val) do {
	///  signed char _val = (signed char)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(signed char), sizeof(signed char));
	///} while (0)"
	public const string GRN_INT8_SET_AT = "(ctx,obj,offset,val) do {\r\n  signed char _val = (signed char)(val);\r\n  grn_bulk_w" +
		"rite_from((ctx), (obj), (char *)&_val,\r\n                      (offset) * sizeof(" +
			"signed char), sizeof(signed char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT8_SET_AT -> "(ctx,obj,offset,val) do { 
	///  unsigned char _val = (unsigned char)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(unsigned char), sizeof(unsigned char));
	///} while (0)"
	public const string GRN_UINT8_SET_AT = "(ctx,obj,offset,val) do { \r\n  unsigned char _val = (unsigned char)(val);\r\n  grn_b" +
		"ulk_write_from((ctx), (obj), (char *)&_val,\r\n                      (offset) * si" +
			"zeof(unsigned char), sizeof(unsigned char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT16_SET_AT -> "(ctx,obj,offset,val) do {
	///  signed short _val = (signed short)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(signed short), sizeof(signed short));
	///} while (0)"
	public const string GRN_INT16_SET_AT = "(ctx,obj,offset,val) do {\r\n  signed short _val = (signed short)(val);\r\n  grn_bulk" +
		"_write_from((ctx), (obj), (char *)&_val,\r\n                      (offset) * sizeo" +
			"f(signed short), sizeof(signed short));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT16_SET_AT -> "(ctx,obj,offset,val) do { 
	///  unsigned short _val = (unsigned short)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(unsigned short), sizeof(unsigned short));
	///} while (0)"
	public const string GRN_UINT16_SET_AT = "(ctx,obj,offset,val) do { \r\n  unsigned short _val = (unsigned short)(val);\r\n  grn" +
		"_bulk_write_from((ctx), (obj), (char *)&_val,\r\n                      (offset) * " +
			"sizeof(unsigned short), sizeof(unsigned short));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT32_SET_AT -> "(ctx,obj,offset,val) do {
	///  int _val = (int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(int), sizeof(int));
	///} while (0)"
	public const string GRN_INT32_SET_AT = "(ctx,obj,offset,val) do {\r\n  int _val = (int)(val);\r\n  grn_bulk_write_from((ctx)," +
		" (obj), (char *)&_val,\r\n                      (offset) * sizeof(int), sizeof(int" +
			"));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT32_SET_AT -> "(ctx,obj,offset,val) do { 
	///  unsigned int _val = (unsigned int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(unsigned int), sizeof(unsigned int));
	///} while (0)"
	public const string GRN_UINT32_SET_AT = "(ctx,obj,offset,val) do { \r\n  unsigned int _val = (unsigned int)(val);\r\n  grn_bul" +
		"k_write_from((ctx), (obj), (char *)&_val,\r\n                      (offset) * size" +
			"of(unsigned int), sizeof(unsigned int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT64_SET_AT -> "(ctx,obj,offset,val) do {
	///  long long int _val = (long long int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(long long int), sizeof(long long int));
	///} while (0)"
	public const string GRN_INT64_SET_AT = "(ctx,obj,offset,val) do {\r\n  long long int _val = (long long int)(val);\r\n  grn_bu" +
		"lk_write_from((ctx), (obj), (char *)&_val,\r\n                      (offset) * siz" +
			"eof(long long int), sizeof(long long int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT64_SET_AT -> "(ctx,obj,offset,val) do {
	///  long long unsigned int _val = (long long unsigned int)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(long long unsigned int),
	///                      sizeof(long long unsigned int));
	///} while (0)"
	public const string GRN_UINT64_SET_AT = @"(ctx,obj,offset,val) do {
  long long unsigned int _val = (long long unsigned int)(val);
  grn_bulk_write_from((ctx), (obj), (char *)&_val,
                      (offset) * sizeof(long long unsigned int),
                      sizeof(long long unsigned int));
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_FLOAT_SET_AT -> "(ctx,obj,offset,val) do {
	///  double _val = (double)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(double), sizeof(double));
	///} while (0)"
	public const string GRN_FLOAT_SET_AT = "(ctx,obj,offset,val) do {\r\n  double _val = (double)(val);\r\n  grn_bulk_write_from(" +
		"(ctx), (obj), (char *)&_val,\r\n                      (offset) * sizeof(double), s" +
			"izeof(double));\r\n} while (0)";

	/// GRN_TIME_SET_AT -> GRN_INT64_SET_AT
	public const string GRN_TIME_SET_AT = UnsupportedConstant.GRN_INT64_SET_AT;

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_RECORD_SET_AT -> "(ctx,obj,offset,val) do {
	///  grn_id _val = (grn_id)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(grn_id), sizeof(grn_id));
	///} while (0)"
	public const string GRN_RECORD_SET_AT = "(ctx,obj,offset,val) do {\r\n  grn_id _val = (grn_id)(val);\r\n  grn_bulk_write_from(" +
		"(ctx), (obj), (char *)&_val,\r\n                      (offset) * sizeof(grn_id), s" +
			"izeof(grn_id));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PTR_SET_AT -> "(ctx,obj,offset,val) do {
	///  grn_obj *_val = (grn_obj *)(val);
	///  grn_bulk_write_from((ctx), (obj), (char *)&_val,
	///                      (offset) * sizeof(grn_obj *), sizeof(grn_obj *));
	///} while (0)"
	public const string GRN_PTR_SET_AT = "(ctx,obj,offset,val) do {\r\n  grn_obj *_val = (grn_obj *)(val);\r\n  grn_bulk_write_" +
		"from((ctx), (obj), (char *)&_val,\r\n                      (offset) * sizeof(grn_o" +
			"bj *), sizeof(grn_obj *));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TIME_PACK -> "(sec,usec) ((long long int)(sec) * GRN_TIME_USEC_PER_SEC + (usec))"
	public const string GRN_TIME_PACK = "(sec,usec) ((long long int)(sec) * GRN_TIME_USEC_PER_SEC + (usec))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TIME_UNPACK -> "(time_value,sec,usec) do {
	///  sec = (time_value) / GRN_TIME_USEC_PER_SEC;
	///  usec = (time_value) % GRN_TIME_USEC_PER_SEC;
	///} while (0)"
	public const string GRN_TIME_UNPACK = "(time_value,sec,usec) do {\r\n  sec = (time_value) / GRN_TIME_USEC_PER_SEC;\r\n  usec" +
		" = (time_value) % GRN_TIME_USEC_PER_SEC;\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_TIME_NOW -> "(ctx,obj) (grn_time_now((ctx), (obj)))"
	public const string GRN_TIME_NOW = "(ctx,obj) (grn_time_now((ctx), (obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BOOL_VALUE -> "(obj) (*((unsigned char *)GRN_BULK_HEAD(obj)))"
	public const string GRN_BOOL_VALUE = "(obj) (*((unsigned char *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT8_VALUE -> "(obj) (*((signed char *)GRN_BULK_HEAD(obj)))"
	public const string GRN_INT8_VALUE = "(obj) (*((signed char *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT8_VALUE -> "(obj) (*((unsigned char *)GRN_BULK_HEAD(obj)))"
	public const string GRN_UINT8_VALUE = "(obj) (*((unsigned char *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT16_VALUE -> "(obj) (*((signed short *)GRN_BULK_HEAD(obj)))"
	public const string GRN_INT16_VALUE = "(obj) (*((signed short *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT16_VALUE -> "(obj) (*((unsigned short *)GRN_BULK_HEAD(obj)))"
	public const string GRN_UINT16_VALUE = "(obj) (*((unsigned short *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT32_VALUE -> "(obj) (*((int *)GRN_BULK_HEAD(obj)))"
	public const string GRN_INT32_VALUE = "(obj) (*((int *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT32_VALUE -> "(obj) (*((unsigned int *)GRN_BULK_HEAD(obj)))"
	public const string GRN_UINT32_VALUE = "(obj) (*((unsigned int *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT64_VALUE -> "(obj) (*((long long int *)GRN_BULK_HEAD(obj)))"
	public const string GRN_INT64_VALUE = "(obj) (*((long long int *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT64_VALUE -> "(obj) (*((long long unsigned int *)GRN_BULK_HEAD(obj)))"
	public const string GRN_UINT64_VALUE = "(obj) (*((long long unsigned int *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_FLOAT_VALUE -> "(obj) (*((double *)GRN_BULK_HEAD(obj)))"
	public const string GRN_FLOAT_VALUE = "(obj) (*((double *)GRN_BULK_HEAD(obj)))";

	/// GRN_TIME_VALUE -> GRN_INT64_VALUE
	public const string GRN_TIME_VALUE = UnsupportedConstant.GRN_INT64_VALUE;

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_RECORD_VALUE -> "(obj) (*((grn_id *)GRN_BULK_HEAD(obj)))"
	public const string GRN_RECORD_VALUE = "(obj) (*((grn_id *)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PTR_VALUE -> "(obj) (*((grn_obj **)GRN_BULK_HEAD(obj)))"
	public const string GRN_PTR_VALUE = "(obj) (*((grn_obj **)GRN_BULK_HEAD(obj)))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_GEO_POINT_VALUE -> "(obj,_latitude,_longitude) do {
	///  grn_geo_point *_val = (grn_geo_point *)GRN_BULK_HEAD(obj);
	///  _latitude = _val->latitude;
	///  _longitude = _val->longitude;
	///} while (0)"
	public const string GRN_GEO_POINT_VALUE = "(obj,_latitude,_longitude) do {\r\n  grn_geo_point *_val = (grn_geo_point *)GRN_BUL" +
		"K_HEAD(obj);\r\n  _latitude = _val->latitude;\r\n  _longitude = _val->longitude;\r\n} " +
			"while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BOOL_VALUE_AT -> "(obj,offset) (((unsigned char *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_BOOL_VALUE_AT = "(obj,offset) (((unsigned char *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT8_VALUE_AT -> "(obj,offset) (((signed char *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_INT8_VALUE_AT = "(obj,offset) (((signed char *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT8_VALUE_AT -> "(obj,offset) (((unsigned char *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_UINT8_VALUE_AT = "(obj,offset) (((unsigned char *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT16_VALUE_AT -> "(obj,offset) (((signed short *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_INT16_VALUE_AT = "(obj,offset) (((signed short *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT16_VALUE_AT -> "(obj,offset) (((unsigned short *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_UINT16_VALUE_AT = "(obj,offset) (((unsigned short *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT32_VALUE_AT -> "(obj,offset) (((int *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_INT32_VALUE_AT = "(obj,offset) (((int *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT32_VALUE_AT -> "(obj,offset) (((unsigned int *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_UINT32_VALUE_AT = "(obj,offset) (((unsigned int *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT64_VALUE_AT -> "(obj,offset) (((long long int *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_INT64_VALUE_AT = "(obj,offset) (((long long int *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT64_VALUE_AT -> "(obj,offset) (((long long unsigned int *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_UINT64_VALUE_AT = "(obj,offset) (((long long unsigned int *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_FLOAT_VALUE_AT -> "(obj,offset) (((double *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_FLOAT_VALUE_AT = "(obj,offset) (((double *)GRN_BULK_HEAD(obj))[offset])";

	/// GRN_TIME_VALUE_AT -> GRN_INT64_VALUE_AT
	public const string GRN_TIME_VALUE_AT = UnsupportedConstant.GRN_INT64_VALUE_AT;

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_RECORD_VALUE_AT -> "(obj,offset) (((grn_id *)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_RECORD_VALUE_AT = "(obj,offset) (((grn_id *)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PTR_VALUE_AT -> "(obj,offset) (((grn_obj **)GRN_BULK_HEAD(obj))[offset])"
	public const string GRN_PTR_VALUE_AT = "(obj,offset) (((grn_obj **)GRN_BULK_HEAD(obj))[offset])";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_BOOL_PUT -> "(ctx,obj,val) do {
	///  unsigned char _val = (unsigned char)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(unsigned char));
	///} while (0)"
	public const string GRN_BOOL_PUT = "(ctx,obj,val) do {\r\n  unsigned char _val = (unsigned char)(val);\r\n  grn_bulk_writ" +
		"e((ctx), (obj), (char *)&_val, sizeof(unsigned char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT8_PUT -> "(ctx,obj,val) do {
	///  signed char _val = (signed char)(val); grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(signed char));
	///} while (0)"
	public const string GRN_INT8_PUT = "(ctx,obj,val) do {\r\n  signed char _val = (signed char)(val); grn_bulk_write((ctx)" +
		", (obj), (char *)&_val, sizeof(signed char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT8_PUT -> "(ctx,obj,val) do {
	///  unsigned char _val = (unsigned char)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(unsigned char));
	///} while (0)"
	public const string GRN_UINT8_PUT = "(ctx,obj,val) do {\r\n  unsigned char _val = (unsigned char)(val);\r\n  grn_bulk_writ" +
		"e((ctx), (obj), (char *)&_val, sizeof(unsigned char));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT16_PUT -> "(ctx,obj,val) do {
	///  signed short _val = (signed short)(val); grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(signed short));
	///} while (0)"
	public const string GRN_INT16_PUT = "(ctx,obj,val) do {\r\n  signed short _val = (signed short)(val); grn_bulk_write((ct" +
		"x), (obj), (char *)&_val, sizeof(signed short));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT16_PUT -> "(ctx,obj,val) do {
	///  unsigned short _val = (unsigned short)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(unsigned short));
	///} while (0)"
	public const string GRN_UINT16_PUT = "(ctx,obj,val) do {\r\n  unsigned short _val = (unsigned short)(val);\r\n  grn_bulk_wr" +
		"ite((ctx), (obj), (char *)&_val, sizeof(unsigned short));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT32_PUT -> "(ctx,obj,val) do {
	///  int _val = (int)(val); grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(int));
	///} while (0)"
	public const string GRN_INT32_PUT = "(ctx,obj,val) do {\r\n  int _val = (int)(val); grn_bulk_write((ctx), (obj), (char *" +
		")&_val, sizeof(int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT32_PUT -> "(ctx,obj,val) do {
	///  unsigned int _val = (unsigned int)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(unsigned int));
	///} while (0)"
	public const string GRN_UINT32_PUT = "(ctx,obj,val) do {\r\n  unsigned int _val = (unsigned int)(val);\r\n  grn_bulk_write(" +
		"(ctx), (obj), (char *)&_val, sizeof(unsigned int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_INT64_PUT -> "(ctx,obj,val) do {
	///  long long int _val = (long long int)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(long long int));
	///} while (0)"
	public const string GRN_INT64_PUT = "(ctx,obj,val) do {\r\n  long long int _val = (long long int)(val);\r\n  grn_bulk_writ" +
		"e((ctx), (obj), (char *)&_val, sizeof(long long int));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_UINT64_PUT -> "(ctx,obj,val) do {
	///  long long unsigned int _val = (long long unsigned int)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(long long unsigned int));
	///} while (0)"
	public const string GRN_UINT64_PUT = "(ctx,obj,val) do {\r\n  long long unsigned int _val = (long long unsigned int)(val)" +
		";\r\n  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(long long unsigned int))" +
			";\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_FLOAT_PUT -> "(ctx,obj,val) do {
	///  double _val = (double)(val); grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(double));
	///} while (0)"
	public const string GRN_FLOAT_PUT = "(ctx,obj,val) do {\r\n  double _val = (double)(val); grn_bulk_write((ctx), (obj), (" +
		"char *)&_val, sizeof(double));\r\n} while (0)";

	/// GRN_TIME_PUT -> GRN_INT64_PUT
	public const string GRN_TIME_PUT = UnsupportedConstant.GRN_INT64_PUT;

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_RECORD_PUT -> "(ctx,obj,val) do {
	///  grn_id _val = (grn_id)(val); grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(grn_id));
	///} while (0)"
	public const string GRN_RECORD_PUT = "(ctx,obj,val) do {\r\n  grn_id _val = (grn_id)(val); grn_bulk_write((ctx), (obj), (" +
		"char *)&_val, sizeof(grn_id));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PTR_PUT -> "(ctx,obj,val) do {
	///  grn_obj *_val = (grn_obj *)(val);
	///  grn_bulk_write((ctx), (obj), (char *)&_val, sizeof(grn_obj *));
	///} while (0)"
	public const string GRN_PTR_PUT = "(ctx,obj,val) do {\r\n  grn_obj *_val = (grn_obj *)(val);\r\n  grn_bulk_write((ctx), " +
		"(obj), (char *)&_val, sizeof(grn_obj *));\r\n} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_CHAR_IS_BLANK -> "(c) ((c) & (GRN_CHAR_BLANK))"
	public const string GRN_CHAR_IS_BLANK = "(c) ((c) & (GRN_CHAR_BLANK))";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_CHAR_TYPE -> "(c) ((c) & 0x7f)"
	public const string GRN_CHAR_TYPE = "(c) ((c) & 0x7f)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_EXPR_CREATE_FOR_QUERY -> "(ctx,table,expr,var) do {
	///  if (((expr) = grn_expr_create((ctx), NULL, 0)) &&
	///      ((var) = grn_expr_add_var((ctx), (expr), NULL, 0))) {
	///    GRN_RECORD_INIT((var), 0, grn_obj_id((ctx), (table)));
	///  } else {
	///    (var) = NULL;
	///  }
	///} while (0)"
	public const string GRN_EXPR_CREATE_FOR_QUERY = "(ctx,table,expr,var) do {\r\n  if (((expr) = grn_expr_create((ctx), NULL, 0)) &&\r\n " +
		"     ((var) = grn_expr_add_var((ctx), (expr), NULL, 0))) {\r\n    GRN_RECORD_INIT(" +
			"(var), 0, grn_obj_id((ctx), (table)));\r\n  } else {\r\n    (var) = NULL;\r\n  }\r\n} wh" +
			"ile (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_HASH_EACH -> "(ctx,hash,id,key,key_size,value,block) do {
	///  grn_hash_cursor *_sc = grn_hash_cursor_open(ctx, hash, NULL, 0, NULL, 0, 0, -1, 0); 
	///  if (_sc) {
	///    grn_id id;
	///    while ((id = grn_hash_cursor_next(ctx, _sc))) {
	///      grn_hash_cursor_get_key_value(ctx, _sc, (void **)(key),
	///                                    (key_size), (void **)(value));
	///      block
	///    }
	///    grn_hash_cursor_close(ctx, _sc);
	///  }
	///} while (0)"
	public const string GRN_HASH_EACH = @"(ctx,hash,id,key,key_size,value,block) do {
  grn_hash_cursor *_sc = grn_hash_cursor_open(ctx, hash, NULL, 0, NULL, 0, 0, -1, 0); 
  if (_sc) {
    grn_id id;
    while ((id = grn_hash_cursor_next(ctx, _sc))) {
      grn_hash_cursor_get_key_value(ctx, _sc, (void **)(key),
                                    (key_size), (void **)(value));
      block
    }
    grn_hash_cursor_close(ctx, _sc);
  }
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_ARRAY_EACH -> "(ctx,array,head,tail,id,value,block) do {
	///  grn_array_cursor *_sc = grn_array_cursor_open(ctx, array, head, tail, 0, -1, 0); 
	///  if (_sc) {
	///    grn_id id;
	///    while ((id = grn_array_cursor_next(ctx, _sc))) {
	///      grn_array_cursor_get_value(ctx, _sc, (void **)(value));
	///      block
	///    }
	///    grn_array_cursor_close(ctx, _sc); 
	///  }
	///} while (0)"
	public const string GRN_ARRAY_EACH = @"(ctx,array,head,tail,id,value,block) do {
  grn_array_cursor *_sc = grn_array_cursor_open(ctx, array, head, tail, 0, -1, 0); 
  if (_sc) {
    grn_id id;
    while ((id = grn_array_cursor_next(ctx, _sc))) {
      grn_array_cursor_get_value(ctx, _sc, (void **)(value));
      block
    }
    grn_array_cursor_close(ctx, _sc); 
  }
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_PAT_EACH -> "(ctx,pat,id,key,key_size,value,block) do {          
	///  grn_pat_cursor *_sc = grn_pat_cursor_open(ctx, pat, NULL, 0, NULL, 0, 0, -1, 0); 
	///  if (_sc) {
	///    grn_id id;
	///    while ((id = grn_pat_cursor_next(ctx, _sc))) {
	///      grn_pat_cursor_get_key_value(ctx, _sc, (void **)(key),
	///                                   (key_size), (void **)(value));
	///      block
	///    }
	///    grn_pat_cursor_close(ctx, _sc);
	///  }
	///} while (0)"
	public const string GRN_PAT_EACH = @"(ctx,pat,id,key,key_size,value,block) do {          
  grn_pat_cursor *_sc = grn_pat_cursor_open(ctx, pat, NULL, 0, NULL, 0, 0, -1, 0); 
  if (_sc) {
    grn_id id;
    while ((id = grn_pat_cursor_next(ctx, _sc))) {
      grn_pat_cursor_get_key_value(ctx, _sc, (void **)(key),
                                   (key_size), (void **)(value));
      block
    }
    grn_pat_cursor_close(ctx, _sc);
  }
} while (0)";

	/// Warning: Generation of Method Macros is not supported at this time
	/// GRN_DAT_EACH -> "(ctx,dat,id,key,key_size,block) do {
	///  grn_dat_cursor *_sc = grn_dat_cursor_open(ctx, dat, NULL, 0, NULL, 0, 0, -1, 0);
	///  if (_sc) {
	///    grn_id id;
	///    unsigned int *_ks = (key_size);
	///    if (_ks) {
	///      while ((id = grn_dat_cursor_next(ctx, _sc))) {
	///        int _ks_raw = grn_dat_cursor_get_key(ctx, _sc, (const void **)(key));
	///        *(_ks) = (unsigned int)_ks_raw;
	///        block
	///      }
	///    } else {
	///      while ((id = grn_dat_cursor_next(ctx, _sc))) {
	///        grn_dat_cursor_get_key(ctx, _sc, (const void **)(key));
	///        block
	///      }
	///    }
	///    grn_dat_cursor_close(ctx, _sc);
	///  }
	///} while (0)"
	public const string GRN_DAT_EACH = @"(ctx,dat,id,key,key_size,block) do {
  grn_dat_cursor *_sc = grn_dat_cursor_open(ctx, dat, NULL, 0, NULL, 0, 0, -1, 0);
  if (_sc) {
    grn_id id;
    unsigned int *_ks = (key_size);
    if (_ks) {
      while ((id = grn_dat_cursor_next(ctx, _sc))) {
        int _ks_raw = grn_dat_cursor_get_key(ctx, _sc, (const void **)(key));
        *(_ks) = (unsigned int)_ks_raw;
        block
      }
    } else {
      while ((id = grn_dat_cursor_next(ctx, _sc))) {
        grn_dat_cursor_get_key(ctx, _sc, (const void **)(key));
        block
      }
    }
    grn_dat_cursor_close(ctx, _sc);
  }
} while (0)";
}

